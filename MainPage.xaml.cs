using FriendEditor.ViewModel;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace FriendEditor
{
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      this.Loaded += MainPage_Loaded;
    }

    private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
    {
      ViewModel = new MainViewModel();
      this.Bindings.Update();
    }

    public MainViewModel ViewModel { get; private set; }
  }
}
