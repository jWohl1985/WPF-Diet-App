using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class Meal
    {
        public float Servings { get; private set; }
        public Food Food { get; private set; }
        public DayOfWeek DayOfWeek { get; private set; }

        public Meal(float servings, Food food, DayOfWeek dayOfWeek)
        {
            this.Servings = servings;
            this.Food = food;
            this.DayOfWeek = dayOfWeek;
        }
    }
}
