using AppChat.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace AppChat.Views;

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
    private void OnEnterClicked(object sender, RoutedEventArgs e)
    {
        string userName = NameTextBox.Text;
        if (!string.IsNullOrEmpty(userName))
        {
            // Điều hướng đến trang chat với tên người dùng
            Frame.Navigate(typeof(ChatPage), userName);
        }
    }
}
