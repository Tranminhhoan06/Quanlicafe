using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Quanlicafe.DAO
{
    public class DataProvider
    {
         private string connectionstr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Quanlicafe;Integrated Security=True";

         public DataTable Execute(string query)
         {
             DataTable data = new DataTable();
             using (SqlConnection connect = new SqlConnection(connectionstr))
             {
                 connect.Open();
                 SqlCommand command = new SqlCommand(query, connect);
                 SqlDataAdapter adapter = new SqlDataAdapter(command);
                 adapter.Fill(data);
                 connect.Close();
                 return (data);
             }
         }
    }
}
