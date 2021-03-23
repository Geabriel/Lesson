using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTask
{
  class Program
  {
    private static List<Book> _books;

    static void Main(string[] args)
    {
      Console.WriteLine("MainThread:" + Thread.CurrentThread.ManagedThreadId);
      Task<long> task1 = new Task<long>(Operation);
      task1.Start();
      task1.ContinueWith(p => Console.WriteLine($"result1: {p.Result}"));


      Task<List<Book>> task2 = new Task<List<Book>>(Get);
      task2.Start();
      task2.ContinueWith(p =>
      {

        Console.WriteLine("Thread: " + Thread.CurrentThread.ManagedThreadId);
        _books = p.Result;
        Console.WriteLine($"result2: {p.Result.Count}");
      }
      );
      Console.WriteLine("Press any key...");
      Console.ReadKey();
           
    }

    private static long Operation()
    {
      Console.WriteLine(MethodInfo.GetCurrentMethod().Name);
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      for (int i = 0; i < 5; i++)
      {
        Thread.Sleep(1000);
        Console.WriteLine(i + 1);
      }
      stopwatch.Stop();
      return stopwatch.ElapsedMilliseconds;
    }

    private static List<Book> Get()
    {
      Console.WriteLine(MethodInfo.GetCurrentMethod().Name);
      Thread.Sleep(3000);
      return new List<Book>();
    }

  }

  class Book
  {
    public int Pages { get; set; }
  }

}
