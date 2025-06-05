using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecsaNutrition.Models;
public class MealPlan
{
    public DateTime Start{ get; set; }
    public DateTime End{ get; set; }
    public List<Food> Foods { get; set; }
}
