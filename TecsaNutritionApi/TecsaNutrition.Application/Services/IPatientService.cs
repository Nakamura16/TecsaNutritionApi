using TecsaNutrition.Models;
using TecsaNutrition.Models.ApiHelpers;

namespace TecsaNutrition.Application.Services;
public interface IPatientService
{
    Task<OperationResult> CreatePatient(Patient patient);
    Task<Patient> GetPatientById(int id);
    Task<OperationResult> UpdatePatient(int id, Patient newPatient);
    Task<OperationResult> DeletetePatient(int id);
}