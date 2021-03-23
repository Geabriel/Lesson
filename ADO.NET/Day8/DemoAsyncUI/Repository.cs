using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoAsyncUI
{
  public class Repository
  {
    public async Task<List<Team>> Get()
    {
      return await Task.Run(() =>
      {
        List<Team> teams = new List<Team>();
        // заполнение из БД
        Thread.Sleep(5000);
        for (int i = 0; i < 5; i++)
        {
          teams.Add(new Team() { Id = i + 1, Name = "Super Ivan" + (i + 1) });
        }

        return teams;
      });
    }


  }
}
