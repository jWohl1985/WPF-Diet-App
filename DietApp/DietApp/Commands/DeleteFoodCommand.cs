using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DietApp.Models;
using DietApp.ViewModels;

namespace DietApp.Commands
{
    public class DeleteFoodCommand : CommandBase
    {
        private FoodListViewModel foodList;

        public DeleteFoodCommand(FoodListViewModel foodList)
        {
            this.foodList = foodList;
            foodList.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return foodList.SelectedFood != null;
        }

        public override void Execute(object? parameter)
        {
            PersistentData.Context.Foods.Remove(foodList.SelectedFood);
            PersistentData.Context.SaveChanges();
            foodList.FoodDatabase.Remove(foodList.SelectedFood);
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(foodList.SelectedFood))
                OnCanExecuteChange();
        }
    }
}
