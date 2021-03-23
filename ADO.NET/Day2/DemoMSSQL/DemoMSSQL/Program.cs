using System;
using System.Configuration;
using System.Linq;

namespace DemoMSSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PizzaMarketDb;Integrated Security=True";

            //2
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            //{
            //    DataSource = @"(LocalDB)\MSSQLLocalDB1111",
            //    InitialCatalog= "PizzaMarketDb",
            //    IntegratedSecurity=true,
            //    //ConnectTimeout=15,
            //    //Pooling = true,
            //    //UserID = "",
            //    //Password=""
            //};

            //3
            string connectionString =
               ConfigurationManager.ConnectionStrings["MarketConnectionString"].ConnectionString;

            using (MarketContex marketContex = new MarketContex(connectionString))
            {
                //marketContex.Log = logInfo => Console.WriteLine(logInfo);

                // string sqlInsert = "INSERT INTO PIZZAS (Name, PRICE, DATE) VALUES ('Dominos', 25.6, '2017-01-01 18:15')";
                //string sqlInsert = "INSERT INTO PIZZAS (Name, PRICE) VALUES (@NAME, @PRICE)";
                string sqlInsert = "INSERT INTO PIZZAS (Name, PRICE, Date) VALUES (@NAME, @PRICE, @Date)";
                // PizzaInfo insertItem = new PizzaInfo() {Name="New Dominos", Price=29.99m, Date=DateTime.Now };
                //int insertedRows = marketContex.Insert<PizzaInfo>(sqlInsert, insertItem);

                var param1 = new QueryPair("@Name", "New Dominos");
                var param2 = new QueryPair("@Price", 29.99);
                var param3 = new QueryPair("@Date", DateTime.Now);
                int insertedRows = marketContex.ExecuteQuery(sqlInsert, param1, param2, param3);
                Console.WriteLine($"{nameof(insertedRows)}: {insertedRows}");

                string sqlDelete = "DELETE FROM PIZZAS WHERE Name=@Name";
                int deletedRows = marketContex.ExecuteQuery(sqlDelete, param1);
                Console.WriteLine($"{nameof(deletedRows)}: {deletedRows}");

                string sqlUpdate = "UPDATE PIZZAS SET Price=@Price WHERE Name=@Name";
                int updatedRows = marketContex.ExecuteQuery(sqlUpdate,
                    new QueryPair("@Name", "Peperoni"), new QueryPair("@Price", 0.05m));
                Console.WriteLine($"{nameof(updatedRows)}: {updatedRows}");

                ShowData(marketContex);
            }

            Console.ReadKey();
        }

        private static void ShowData(MarketContex marketContex)
        {
            var pizzas = marketContex.Get<PizzaInfo>("SELECT Name, Price, Date FROM PIZZAS");
            pizzas.ToList().ForEach(p => { Console.WriteLine(p); });
        }
    }
}
