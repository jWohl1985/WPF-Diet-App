using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DietApp.Commands;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public UserListViewModel Users { get; set; }
        public WeightLogViewModel Weights { get; set; }
        public FoodListViewModel Foods { get; set; }
        public MealPlanViewModel Meals { get; set; }

        public MainViewModel()
        {
            Users = new UserListViewModel();
            Weights = new WeightLogViewModel(Users);
            Foods = new FoodListViewModel(this);
            Meals = new MealPlanViewModel(this);
        }
    }
}
