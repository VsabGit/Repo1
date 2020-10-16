using FriendEditor.Base;
using FriendEditor.Model;
using System;
using System.Collections.ObjectModel;

namespace FriendEditor.ViewModel
{
  public class MainViewModel : Observable
  {
    private Friend _selectedFriend;

    public MainViewModel()
    {
      Friends = new ObservableCollection<Friend>
      {
        new Friend { FirstName="Thomas",LastName="Huber",Birthday=new DateTime(1980,10,28)},
        new Friend { FirstName="Julia",LastName="Huber",Birthday=new DateTime(1980,11,28)},
        new Friend { FirstName="Urs",LastName="Meier",Birthday=new DateTime(1970,2,17)},
        new Friend { FirstName="Chrissi",LastName="Egin",Birthday=new DateTime(1985,5,13)},
      };
    }

    public void DeleteFriend()
    {
      if(IsFriendSelected)
      {
        Friends.Remove(SelectedFriend);
        SelectedFriend = null;
      }
    }

    public ObservableCollection<Friend> Friends { get; private set; }

    public Friend SelectedFriend
    {
      get { return _selectedFriend; }
      set
      {
        if (_selectedFriend != value)
        {
          _selectedFriend = value;
          OnPropertyChanged();
          OnPropertyChanged(nameof(IsFriendSelected));
        }
      }
    }

    public bool IsFriendSelected
    {
      get { return SelectedFriend != null; }
    }
  }
}
