using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DietApp.Models;
using DietApp.ViewModels;

namespace DietApp.Commands
{
    public class AddFoodCommand : ICommand
    {
        private FoodListViewModel foodList;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Food banana = new Food("Banana", 90, 2.5f, 22, .1f);
            foodList.FoodDatabase.Add(banana);
            PersistentData.Context.Foods.Add(banana);
            PersistentData.Context.SaveChanges();
        }

        public AddFoodCommand(FoodListViewModel foodList)
        {
            this.foodList = foodList;
        }
    }
}
