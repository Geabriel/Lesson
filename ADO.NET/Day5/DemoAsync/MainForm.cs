using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAsync
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnNoAsync_Click(object sender, EventArgs e)
    {
      SqlConnection connection = new SqlConnection()
      {
        ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PizzaMarketDb;Integrated Security=True"
      };
      try
      {
        connection.Open();
        var cmd = connection.CreateCommand();
        cmd.CommandText = "WAITFOR DELAY '0:0:05' SELECT * FROM PIZZAS";

        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
          var info = String.Format($"{reader[1]} {reader[2]}");
          lsbInfo.Items.Add(info);
        }
      }
      finally
      {
        connection.Close();
      }
    }

    private async void btnAsyncAwait_Click(object sender, EventArgs e)
    {
      SqlConnection connection = new SqlConnection()
      {
        ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PizzaMarketDb;Integrated Security=True"
      };
      try
      {
        connection.Open();
        var cmd = connection.CreateCommand();
        cmd.CommandText = "WAITFOR DELAY '0:0:05' SELECT * FROM PIZZAS";

        var reader = await cmd.ExecuteReaderAsync();
        while (reader.Read())
        {
          var info = String.Format($"{reader[1]} {reader[2]}");
          lsbInfo.Items.Add(info);
        }
      }
      finally
      {
        connection.Close();
      }
    }

    private void btnOldAsync_Click(object sender, EventArgs e)
    {
      SqlConnection connection = new SqlConnection()
      {
        ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PizzaMarketDb;Integrated Security=True"
      };

      connection.Open();
      var cmd = connection.CreateCommand();
      cmd.CommandText = "WAITFOR DELAY '0:0:05' SELECT * FROM PIZZAS";

      AsyncCallback asyncCallBack = new AsyncCallback(ExecuteReaderCallBack);
      cmd.BeginExecuteReader(asyncCallBack, cmd);

    }

    private void ExecuteReaderCallBack(IAsyncResult ar)
    {
      SqlCommand cmd = ar.AsyncState as SqlCommand;
      SqlDataReader reader = cmd.EndExecuteReader(ar);
      while (reader.Read())
      {
        var info = String.Format($"{reader[1]} {reader[2]}");
        var action = new Action<string>(UpdateListBox);
        this.Invoke(action, info);
      }
    }

    private void UpdateListBox(string info)
    {
      lsbInfo.Items.Add(info);
    }

  }
}
