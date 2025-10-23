using ResturantReserve.ModelsLogic;
using ResturantReserve.Views;

namespace ResturantReserve
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            User user = new();
            Page page = user.IsRegistered ? new LoginPage() : new RegisterPage();
            MainPage = page;
        }
    }
}
