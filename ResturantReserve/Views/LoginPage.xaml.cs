using ResturantReserve.ViewModels;

namespace ResturantReserve.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginPageVM();
    }
}