using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BAPDatabase
{
    public abstract class BaseDB
    {
        public string connectionString = @"Data Source = CORNER01\SQLEXPRESS;Initial Catalog = RssFeedDB; Integrated Security = True";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public BaseDB()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public void ExecuteReader(string query)
        {
            command.CommandText = query;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                CreateModel();
            }
            catch (Exception e)
            {}
            finally
            {
                connection.Close();
            }
        }
        public abstract void CreateModel();
    }
}
