using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecsaNutrition.Application.Repository;
using TecsaNutrition.Models;
using TecsaNutrition.Models.ApiHelpers;

namespace TecsaNutrition.Application.Services.Impl;

public class PatientService : IPatientService
{
    private IPatientRepository patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        this.patientRepository = patientRepository;
    }

    public async Task<Patient> GetPatientById(int id)
    {
        return await patientRepository.GetPatientById(id);
    }

    public async Task<OperationResult> CreatePatient(Patient patient)
    {
        return await patientRepository.CreatePatient(patient);
    }
}
