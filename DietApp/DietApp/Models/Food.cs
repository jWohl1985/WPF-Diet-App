using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class Food
    {
        // Entity relationships
        public int FoodId { get; set; }

        // Food properties
        public string Name { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }

        public Food(string name, float calories, float protein, float carbs, float fat)
        {
            this.Name = name;
            this.Calories = calories;
            this.Protein = protein;
            this.Carbs = carbs;
            this.Fat = fat;
        }

        public Food()
        {

        }
    }
}
