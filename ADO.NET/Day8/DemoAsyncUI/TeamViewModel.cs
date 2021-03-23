using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace DemoAsyncUI
{
  public class TeamViewModel
  {
    private Repository _repository;

    public Repository Repository
    {
      get
      {
        return _repository ?? (_repository = new Repository());
      }
    }



    public ObservableCollection<Team> Teams { get; }
    public TeamViewModel()
    {
     
      Teams = new ObservableCollection<Team>();
      Initialize();
    }

    private async void Initialize()
    {
      var collection = await Repository.Get();
      foreach (var item in collection)
      {
        Teams.Add(item);
      }

    }
  }
}
