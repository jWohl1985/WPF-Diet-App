using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class TestViewModel
    {
        public string UserName { get; private set; }
        public string FoodName { get; private set; }
        public string MealDescription { get; private set; }

        public TestViewModel(User user, Food food, Meal meal)
        {
            UserName = user.Name;
            FoodName = food.Name;
            MealDescription = $"{meal.Servings} + {meal.Food.Name} + {meal.DayOfWeek}";
        }
    }
}
