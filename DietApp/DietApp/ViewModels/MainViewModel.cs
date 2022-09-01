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
        public FoodListViewModel FoodList { get; set; }

        public MainViewModel()
        {
            FoodList = new FoodListViewModel();
        }
    }
}
