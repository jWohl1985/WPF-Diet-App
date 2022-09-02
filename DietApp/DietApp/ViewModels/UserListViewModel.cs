using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DietApp.Models;

namespace DietApp.ViewModels
{
    public class UserListViewModel : ViewModelBase
    {
        private User selectedUser;

        public ObservableCollection<User> UserList { get; private set; }
        public User SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                UserChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler UserChanged;

        public UserListViewModel()
        {
            UserList = new ObservableCollection<User>();
            List<User> users = PersistentData.Context.Users.ToList();
            foreach (User user in users)
            {
                UserList.Add(user);
            }

            SelectedUser = UserList.FirstOrDefault();
        }
    }
}
