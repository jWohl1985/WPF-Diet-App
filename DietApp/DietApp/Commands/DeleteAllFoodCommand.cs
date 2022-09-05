using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;
using DietApp.ViewModels;

namespace DietApp.Commands
{
    public class DeleteAllFoodCommand : CommandBase
    {
        private FoodListViewModel foodList;

        public DeleteAllFoodCommand(FoodListViewModel foodList)
        {
            this.foodList = foodList;
        }

        public override void Execute(object? parameter)
        {
            foreach(Food food in PersistentData.Context.Foods)
            {
                PersistentData.Context.Foods.Remove(food);
            }
            PersistentData.Context.SaveChanges();
            foodList.FoodDatabase.Clear();
        }
    }
}
