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
        private UserListViewModel userListVM;
        private DayOfWeek selectedDay;

        public User SelectedUser => userListVM.SelectedUser;
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

        public MealPlanViewModel(UserListViewModel userListVM)
        {
            MealPlan = new ObservableCollection<Meal>();
            this.userListVM = userListVM;
            this.userListVM.UserChanged += OnUserChanged;
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
