using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class MealPlanViewModel : ViewModelBase
    {
        private MainViewModel mainViewModel;
        private DayOfWeek selectedDay;

        public User SelectedUser => mainViewModel.Users.SelectedUser;
        public ObservableCollection<Meal> MealPlan { get; set; }
        public DayOfWeek SelectedDay 
        {
            get => selectedDay;
            set
            {
                selectedDay = value;
                UpdateDisplayedMeals();
            }
        }

        public MealPlanViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            MealPlan = new ObservableCollection<Meal>();
            mainViewModel.Users.UserChanged += OnUserChanged;
            SelectedDay = DateTime.Today.DayOfWeek;
            UpdateDisplayedMeals();
        }

        private void OnUserChanged(object? sender, EventArgs e) => UpdateDisplayedMeals();

        private void UpdateDisplayedMeals()
        {
            MealPlan.Clear();

            List<Meal> mealsToDisplay = PersistentData.Context.Meals
                .Where(meal => (meal.User == SelectedUser) && (meal.DayOfWeek == selectedDay))
                .ToList();

            foreach (Meal meal in mealsToDisplay)
            {
                MealPlan.Add(meal);
            }
        }
    }
}
