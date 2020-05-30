using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Quanlicafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider(){}

         private string connectionstr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Quanlicafe;Integrated Security=True";

         public DataTable ExecuteQuery(string query)
         {
             DataTable data = new DataTable();
             using (SqlConnection connect = new SqlConnection(connectionstr))
             {
                 connect.Open();
                 SqlCommand command = new SqlCommand(query, connect);
                 SqlDataAdapter adapter = new SqlDataAdapter(command);
                 adapter.Fill(data);
                 connect.Close();
             }
             return (data);
             //SqlConnection connect = new SqlConnection(connectionstr);
             //       connect.Open();
             //SqlCommand command = new SqlCommand(query, connect);
             //DataTable data = new DataTable();
             //SqlDataAdapter adapter = new SqlDataAdapter(command);
             //adapter.Fill(data);
             //connect.Close();
             //return data;
         }
         public int ExecuteNonQuery(string query)
         {
             int data = 0;
             using (SqlConnection connect = new SqlConnection(connectionstr))
             {
                 connect.Open();
                 SqlCommand command = new SqlCommand(query, connect);
                 data = command.ExecuteNonQuery();
                 connect.Close();
             }
             return (data);
         }

         public object ExecuteScalar(string query)
         {
             object data = 0;
             using (SqlConnection connect = new SqlConnection(connectionstr))
             {
                 connect.Open();
                 SqlCommand command = new SqlCommand(query, connect);
                 SqlDataAdapter adapter = new SqlDataAdapter(command);
                 data = command.ExecuteScalar();
                 connect.Close();
             }
             return (data);
         }
    }
}
