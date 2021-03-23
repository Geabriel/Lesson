using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoAsyncUI
{
  internal class Server
  {

    public async Task<long> PingAsync(List<string> urls, IProgress<double> progres)
    {
      return await Task.Run(() =>
     {
       Stopwatch stopwatch = new Stopwatch();
       stopwatch.Start();
       for (int i = 0; i < urls.Count; i++)
       {
         Thread.Sleep(550);
         progres.Report(((double)(i+1)/urls.Count)*100.0);
       }
       stopwatch.Stop();
       return stopwatch.ElapsedMilliseconds;
     });
    }


    

  }
}
