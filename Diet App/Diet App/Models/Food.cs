using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class Food
    {
        public string Name { get; private set; }
        public float Calories { get; private set; }
        public float Protein { get; private set; }
        public float Carbs { get; private set; }
        public float Fat { get; private set; }

        public Food(string name, float calories, float protein, float carbs, float fat)
        {
            this.Name = name;
            this.Calories = calories;
            this.Protein = protein;
            this.Carbs = carbs;
            this.Fat = fat;
        }
    }
}
