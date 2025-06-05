using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using TecsaNutrition.Application.Repository;
using TecsaNutrition.Data.Converter;
using TecsaNutrition.Data.Entity;
using TecsaNutrition.Data.Exceptions;
using TecsaNutrition.Models;
using TecsaNutrition.Models.ApiHelpers;

namespace TecsaNutrition.Data.Repository;

public class PatientRepository : IPatientRepository
{
    private readonly TecsaNutritionContext context;
    private readonly IPatientConverter converter;

    public PatientRepository(
        TecsaNutritionContext context,
        IPatientConverter converter)
    {
        this.context = context;
        this.converter = converter;
    }

    public async Task<OperationResult> CreatePatient(Patient patient)
    {
        try
        {
            var patientEntity = converter.ToEntity(patient);
            context.Patients.Add(patientEntity);
            await context.SaveChangesAsync();
            return new OperationResult(true, string.Empty);
        }
        catch (Exception ex) 
        {
            return new OperationResult(false, ex.Message);
        }
    }

    public async Task<Patient> GetPatientById(int id)
    {
        PatientEntity maybePatient = await FindPatientBy(id);
        return converter.ToModel(maybePatient);
    }

    public async Task<OperationResult> UpdatePatient(int id,Patient newPatient)
    {
        try
        {
            var existingPatient = await FindPatientBy(id);

            existingPatient.Name = newPatient.Name;
            existingPatient.Email = newPatient.Email;
            existingPatient.PhoneNumber = newPatient.PhoneNumber;
            existingPatient.Gender = newPatient.Gender.ToString();
            existingPatient.Weight = newPatient.Weight;
            existingPatient.HeightInCentimeters = newPatient.HeightInCentimeters;

            context.Patients.Update(existingPatient);
            await context.SaveChangesAsync();

            return new OperationResult(true, string.Empty);
        }
        catch (Exception ex) 
        {
            return new OperationResult(false, ex.Message);
        }
    }

    public async Task<OperationResult> DeletetePatient(int id)
    {
        try
        {
            PatientEntity maybePatient = await FindPatientBy(id);
            context.Patients.Remove(maybePatient);
            context.SaveChanges();
            return new OperationResult(true, string.Empty);
        }
        catch (Exception ex) 
        {
            return new OperationResult(false, ex.Message);
        }
    }

    private async Task<PatientEntity> FindPatientBy(int id)
    {
        return await context.Patients.FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new NotFoundException($"Patient with Id [{id}] was not found.");
    }
}
