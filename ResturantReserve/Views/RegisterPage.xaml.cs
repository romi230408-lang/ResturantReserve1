using ResturantReserve.ViewModels;

namespace ResturantReserve.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterPageVM();
        }
    }
}