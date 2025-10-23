using ResturantReserve.Models;
using System.Windows.Input;
using Microsoft.Maui.Storage;
using ResturantReserve.ModelsLogic;


namespace ResturantReserve.ViewModels
{
    public partial class LoginPageVM: ObservableObject
    {
        private User user = new();
        public ICommand LoginCommand { get; set; }

        public string Email
        {
            get => user.Email;
            set
            {
                if (user.Email != value)
                {
                    user.Email = value;
                    OnPropertyChanged();
                    (LoginCommand as Command)?.ChangeCanExecute();
                }
            }

        }

        public string Password
        {
            get => user.Password;
            set
            {
                if (user.Password != value)
                {
                    user.Password = value;
                    OnPropertyChanged();
                    (LoginCommand as Command)?.ChangeCanExecute();
                }
            }
        }

        public bool CanLogIn()
        {
            return !string.IsNullOrWhiteSpace(Email) &&
                   !string.IsNullOrWhiteSpace(Password);
        }

        public LoginPageVM()
        {
            LoginCommand = new Command(LogIn);
        }

        private void LogIn()
        {
            user.Login();
        }

    }

}
