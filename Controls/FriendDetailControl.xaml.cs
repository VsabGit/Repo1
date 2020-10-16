using FriendEditor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FriendEditor.Controls
{
  public sealed partial class FriendDetailControl : UserControl
  {
    public FriendDetailControl()
    {
      this.InitializeComponent();
    }

    private Friend _friend;

    public Friend Friend
    {
      get { return _friend; }
      set
      {
        _friend = value;
        this.Bindings.Update();
      }
    }

    public Brush GetDeveloperBrush(bool isDeveloper)
    {
      if (isDeveloper)
      {
        return new SolidColorBrush(Colors.SteelBlue);
      }
      return null;
    }
  }
}
