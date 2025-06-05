using TecsaNutrition.Data.Entity;
using TecsaNutrition.Models;

namespace TecsaNutrition.Data.Converter;
public interface IPatientConverter
{
    PatientEntity ToEntity(Patient model);
    Patient ToModel(PatientEntity entity);
}