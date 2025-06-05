using TecsaNutrition.Data.Entity;
using TecsaNutrition.Models;

namespace TecsaNutrition.Data.Converter.Impl;

public class PatientConverter : IPatientConverter
{
    public Patient ToModel(PatientEntity entity)
    {
        return new Patient(
            name: entity.Name,
            email: entity.Email,
            phoneNumber: entity.PhoneNumber,
            gender: Enum.Parse<Gender>(entity.Gender),
            weight: entity.Weight,
            heightInCentimeters: entity.HeightInCentimeters);
    }

    public PatientEntity ToEntity(Patient model)
    {
        return new PatientEntity(
            name: model.Name,
            email: model.Email,
            phoneNumber: model.PhoneNumber,
            gender: model.Gender.ToString(),
            weight: model.Weight,
            heightInCentimeters: model.HeightInCentimeters);
    }
}
