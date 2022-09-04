using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public User SelectedUser => UserList.SelectedUser;
        public DayOfWeek DayOfWeek => MealPlan.SelectedDay;

        public UserListViewModel UserList { get; set; }
        public WeightLogViewModel WeightLog { get; set; }
        public FoodListViewModel FoodList { get; set; }
        public MealPlanViewModel MealPlan { get; set; }

        public MainViewModel()
        {
            UserList = new UserListViewModel();
            WeightLog = new WeightLogViewModel(UserList);
            FoodList = new FoodListViewModel();
            MealPlan = new MealPlanViewModel(UserList);
        }
    }
}
