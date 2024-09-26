using AppChat.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AppChat.Views;

public sealed partial class ChatPage : Page
{
    public ChatViewModel ViewModel
    {
        get;
    }

    public ChatPage()
    {
        ViewModel = App.GetService<ChatViewModel>();
       
    }
}
