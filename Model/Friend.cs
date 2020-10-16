using FriendEditor.Base;
using System;

namespace FriendEditor.Model
{
  public class Friend : Observable
  {
    private string _firstName;
    private string _lastName;
    private bool _isDeveloper;
    private DateTime _birthday;

    public string FirstName
    {
      get { return _firstName; }
      set
      {
        _firstName = value;
        OnPropertyChanged();
      }
    }

    public string LastName
    {
      get { return _lastName; }
      set
      {
        _lastName = value;
        OnPropertyChanged();
      }
    }

    public bool IsDeveloper
    {
      get { return _isDeveloper; }
      set
      {
        _isDeveloper = value;
        OnPropertyChanged();
      }
    }

    public DateTime Birthday
    {
      get { return _birthday; }
      set
      {
        _birthday = value;
        OnPropertyChanged();
      }
    }

  }
}
