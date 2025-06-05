using System.Reflection;

namespace TecsaNutrition.Data.Entity;

public class PatientEntity
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public double Weight { get; set; }
    public int HeightInCentimeters { get; set; }
    
    public PatientEntity(int id,
        string name,
        string email,
        string phoneNumber,
        string gender,
        double weight,
        int heightInCentimeters)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Gender = gender;
        Weight = weight;
        HeightInCentimeters = heightInCentimeters;
    }
}
