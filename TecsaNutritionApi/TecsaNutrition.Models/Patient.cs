namespace TecsaNutrition.Models;

public class Patient
{
    public string Name{ get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Gender Gender { get; set; }
    public double Weight { get; set; }
    public int HeightInCentimeters { get; set; }

    public Patient(
        string name,
        string email,
        string phoneNumber,
        Gender gender,
        double weight,
        int heightInCentimeters)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Gender = gender;
        Weight = weight;
        HeightInCentimeters = heightInCentimeters;
    }
}

public enum Gender
{
    Male,
    Female,
    Other
}
