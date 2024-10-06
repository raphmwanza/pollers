using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polling;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
        NavigateToMainPage();
    }
    private async void NavigateToMainPage()
    {
        await Task.Delay(5000); // Wait for 5 seconds
        await Shell.Current.GoToAsync("//MainPage");
    }
}