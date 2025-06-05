namespace TecsaNutrition.Models;

public class Patient
{
    public string Name{ get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Gender Gender { get; set; }
    public double Weight { get; set; }
    public int HeightInCentimeters { get; set; }
    public MealPlan MealPlan{ get; set; }

    public Patient(
        string name,
        string email,
        string phoneNumber,
        Gender gender,
        double weight,
        int heightInCentimeters,
        MealPlan mealPlan)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Gender = gender;
        Weight = weight;
        HeightInCentimeters = heightInCentimeters;
        MealPlan = mealPlan;
    }
}

public enum Gender
{
    Male,
    Female,
    Other
}
