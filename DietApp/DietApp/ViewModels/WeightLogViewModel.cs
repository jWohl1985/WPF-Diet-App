using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class WeightLogViewModel : ViewModelBase
    {
        private UserListViewModel userListVM;
        private User selectedUser => userListVM.SelectedUser;

        public ObservableCollection<WeightLogEntry> WeightLogEntries { get; set; } = new ObservableCollection<WeightLogEntry>();

        public WeightLogViewModel(UserListViewModel userListVM)
        {
            this.userListVM = userListVM;
            this.userListVM.UserChanged += OnUserChanged;
            UpdateWeightLogDisplay();
        }

        private void OnUserChanged(object? sender, EventArgs e) => UpdateWeightLogDisplay();

        private void UpdateWeightLogDisplay()
        {
            List<WeightLogEntry> entries = new List<WeightLogEntry>();

            entries = PersistentData.Context.WeightLogs
                .Where(entry => entry.UserId == selectedUser.UserId)
                .ToList();

            WeightLogEntries.Clear();
            
            foreach(WeightLogEntry entry in entries)
            {
                WeightLogEntries.Add(entry);
            }
        }

    }
}
