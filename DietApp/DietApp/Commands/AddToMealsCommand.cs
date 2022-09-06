using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;
using DietApp.ViewModels;

namespace DietApp.Commands
{
    public class AddToMealsCommand : CommandBase
    {
        private MainViewModel mainViewModel;

        public AddToMealsCommand(MainViewModel mainViewModel, FoodListViewModel foodListVM)
        {
            this.mainViewModel = mainViewModel;
            foodListVM.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return mainViewModel.Foods.SelectedFood != null;
        }

        public override void Execute(object? parameter)
        {
            Meal meal = new Meal
            {
                User = mainViewModel.Users.SelectedUser,
                Food = mainViewModel.Foods.SelectedFood,
                Servings = 1,
                DayOfWeek = mainViewModel.Meals.SelectedDay,
            };
            PersistentData.Context.Meals.Add(meal);
            PersistentData.Context.SaveChanges();
            mainViewModel.Meals.MealPlan.Add(meal);
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(mainViewModel.Foods.SelectedFood))
                OnCanExecuteChange();
        }
    }
}
