using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DietApp.Commands;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class FoodListViewModel : ViewModelBase
    {
        private Food selectedFood;

        public ObservableCollection<Food> FoodDatabase { get; private set; }
        public ICommand AddFoodCommand { get; set; }
        public ICommand DeleteFoodCommand { get; set; }
        public ICommand ImportDatabaseCommand { get; set; }
        public ICommand ExportDatabaseCommand { get; set; }
        public ICommand DeleteDatabaseCommand { get; set; }
        public Food SelectedFood 
        {
            get => selectedFood;
            set
            {
                selectedFood = value;
                OnPropertyChanged(nameof(SelectedFood));
            }
        }

        public FoodListViewModel()
        {
            FoodDatabase = new ObservableCollection<Food>();
            List<Food> foods = PersistentData.Context.Foods.ToList();
            foreach (Food food in foods)
            {
                FoodDatabase.Add(food);
            }

            AddFoodCommand = new AddFoodCommand(this);
            DeleteFoodCommand = new DeleteFoodCommand(this);
        }
    }
}
