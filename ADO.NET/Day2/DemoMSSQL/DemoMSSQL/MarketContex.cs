using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace DemoMSSQL
{
    internal class MarketContex : IDisposable
    {
        public Action<string> Log { get; set; }
        public string ConnectionString { get; }
        public object Name { get; private set; }

        private SqlConnection _connection;

        public MarketContex(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException();
            }
            ConnectionString = connectionString;
        }


        public IEnumerable<T> Get<T>(string sqlQuery) where T : class, new()
        {
            List<T> collection = new List<T>();
            Connect();
            SqlCommand cmdGet = _connection.CreateCommand();
            cmdGet.CommandText = sqlQuery;
            SqlDataReader reader = cmdGet.ExecuteReader();
            while (reader.Read())
            {
                var item = Parse<T>(reader);
                collection.Add(item);
            }
            reader.Close();
            Close();

            return collection;
        }

        private T Parse<T>(IDataReader reader) where T : class, new()
        {
            Type type = typeof(T);
            IEnumerable<PropertyInfo> props = type.GetProperties().ToList();

            var obj = Activator.CreateInstance(type);

            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.IsDBNull(i))
                    continue;

                var prop = props.FirstOrDefault(p => p.Name.Equals(reader.GetName(i)));
                prop?.SetValue(obj, reader[i]);
            }

            return obj as T;
        }

        public int ExecuteQuery(string sqlQuery, params QueryPair[] queryParams)
        {
            Connect();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = sqlQuery;

            foreach (var parametr in queryParams)
            {
                cmd.Parameters.AddWithValue(parametr.Name, parametr.Value);
            }

            int countRows = cmd.ExecuteNonQuery();
            Close();
            return countRows;
        }

        public int Insert<T>(string sqlQuery, T item)
        {
            Connect();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = sqlQuery;

            List<PropertyInfo> props = item.GetType().GetProperties().ToList();
            foreach (var prop in props)
            {
                //cmd.Parameters.AddWithValue(String.Concat("@", prop.Name), prop.GetValue(item));

                SqlParameter parametr = new SqlParameter()
                {
                    ParameterName= String.Concat("@", prop.Name),
                    Value = prop.GetValue(item),
                    Direction=ParameterDirection.Input
                };
                cmd.Parameters.Add(parametr);
            }

            int countRows = cmd.ExecuteNonQuery();
            Close();
            return countRows;
        }

        public int Insert(string sqlQuery)
        {
            Connect();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = sqlQuery;
            int countRows = cmd.ExecuteNonQuery();
            Close();
            return countRows;
        }



        private void Connect()
        {
            _connection = new SqlConnection();
            _connection.StateChange += Connection_StateChange;
            _connection.ConnectionString = ConnectionString;

            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        private void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            WriteLog($"Connection State: {e.CurrentState}");
        }

        private void WriteLog(string logInfo)
        {
            Log?.Invoke(logInfo);
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        private void Close()
        {
            Dispose();
        }

    }

    public class QueryPair
    {
        public QueryPair(string name, object value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; }
        public object Value { get; }
    }

}
