using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class Meal
    {
        // Entity relationships
        public int MealId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }

        // Meal properties
        public float Servings { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public Meal(float servings, Food food, DayOfWeek dayOfWeek)
        {
            this.Servings = servings;
            this.Food = food;
            this.DayOfWeek = dayOfWeek;
        }

        public Meal()
        {

        }
    }
}
