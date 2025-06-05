using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TecsaNutrition.Data.Entity;

public class PatientEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public double Weight { get; set; }
    public int HeightInCentimeters { get; set; }
    
    public PatientEntity(
        string name,
        string email,
        string phoneNumber,
        string gender,
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
