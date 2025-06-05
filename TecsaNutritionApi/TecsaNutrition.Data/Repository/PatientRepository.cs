using System.Security.AccessControl;
using TecsaNutrition.Application;
using TecsaNutrition.Models;
using TecsaNutrition.Models.ApiHelpers;

namespace TecsaNutrition.Data.Repository;

public class PatientRepository : IPatientRepository
{
    private readonly TecsaNutritionContext context;

    public PatientRepository(TecsaNutritionContext context)
    {
        this.context = context;
    }

    public Task<OperationResult> CreatePatient(Patient patient)
    {
        throw new NotImplementedException();
    }

    public Task<Patient> GetPatientById(int id)
    {
        throw new NotImplementedException();
    }
}
