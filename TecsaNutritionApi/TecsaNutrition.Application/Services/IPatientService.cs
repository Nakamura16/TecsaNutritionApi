using TecsaNutrition.Models;
using TecsaNutrition.Models.ApiHelpers;

namespace TecsaNutrition.Application.Services;
public interface IPatientService
{
    Task<OperationResult> CreatePatient(Patient patient);
    Task<Patient> GetPatientById(int id);
}