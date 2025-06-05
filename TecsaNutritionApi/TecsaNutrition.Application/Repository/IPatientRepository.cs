using TecsaNutrition.Models;
using TecsaNutrition.Models.ApiHelpers;

namespace TecsaNutrition.Application.Repository;

public interface IPatientRepository
{
    Task<Patient> GetPatientById(int id);
    Task<OperationResult> CreatePatient(Patient patient);
}
