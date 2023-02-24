using Microsoft.UI.Xaml.Controls;

using TempStudio_WinUI.ViewModels;

namespace TempStudio_WinUI.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
