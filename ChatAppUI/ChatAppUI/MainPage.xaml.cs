using ChatUI.Services;

namespace ChatAppUI;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = new ChatUI.Models.BindableMessageModel(new MessageService());
    }
}
