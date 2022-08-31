using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DietApp.Models;
using DietApp.ViewModels;

namespace Diet_App
{
    public partial class MainWindow : Window
    {
        private DietContext context;
        public TestViewModel Test { get; set; }
        
        public MainWindow(DietContext context)
        {
            InitializeComponent();
            this.context = context;
            Test = new TestViewModel(context.Users.Find(1), context.Foods.Find(1), context.Meals.Find(1));
            this.DataContext = this;
        }
    }
}
