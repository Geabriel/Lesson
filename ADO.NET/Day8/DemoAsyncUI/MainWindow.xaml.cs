using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DemoAsyncUI
{
  public partial class MainWindow : Window
  {

   // private SynchronizationContext _synchronizationContext;

    public MainWindow()
    {
      InitializeComponent();
    //  _synchronizationContext = SynchronizationContext.Current;
    }

    private void btnStart_Click(object sender, RoutedEventArgs e)
    {
      //Task.Run((Action)Counter);
      //Task.Run(()=>Counter());

      //Task.Run(() => 
      //{
      //  for (int i = 0; i < 5; i++)
      //  {
      //    Thread.Sleep(1000);
      //    //Dispatcher.Invoke(() => { lbCounter.Content = i + 1; });
      //    _synchronizationContext.Post(p => { lbCounter.Content = (int)p + 1; }, i);
      //  }
      //});
    }

    //private void Counter()
    //{
    //  for (int i = 0; i < 5; i++)
    //  {
    //    Thread.Sleep(1000);
    //    Dispatcher.Invoke(()=> { lbCounter.Content = i + 1; });
    //  }
    //}

    private async void btnStartPing_Click(object sender, RoutedEventArgs e)
    {
      //List<string> urls = new List<string>() {"1","2","3","4","5" ,"6"};
      //Server server = new Server();

      //Progress<double> progress
      //  = new Progress<double>(value => pbProcess.Value = value);

      //long time = await server.PingAsync(urls, progress);
      //lbPingTime.Content = time;
     }
  }
}
