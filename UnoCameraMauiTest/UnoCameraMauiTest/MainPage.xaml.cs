namespace UnoCameraMauiTest;

public sealed partial class MainPage : Page
{
    public MainPageViewModel ViewModel { get; } = new MainPageViewModel();
    public MainPage()
    {
        this.InitializeComponent();
    }
}
