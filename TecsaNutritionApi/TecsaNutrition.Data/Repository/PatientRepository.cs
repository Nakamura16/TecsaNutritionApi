using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using TecsaNutrition.Application;
using TecsaNutrition.Data.Converter;
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
        var maybePatient = await context.Patients.FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new NotFoundException($"Patient with Id [{id}] was not found.");

        return converter.ToModel(maybePatient);
    }
}
