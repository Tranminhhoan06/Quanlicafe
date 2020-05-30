using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Quanlicafe.DAO;
using System.Windows.Forms;

namespace Quanlicafe.DAO
{
    public class loginDAO
    {
        public bool Login(string username, string pass)
        {
                string query = "SELECT * FROM dbo.TAIKHOAN WHERE UNAME = '" + username + "' and PASS = '" + pass + "'";
                DataProvider provider = new DataProvider();
                DataTable da = provider.ExecuteQuery(query);
                return da.Rows.Count > 0;
        }
        public void kiemtra(string username, string pass)
        {
            if (username.Length > 20)
                MessageBox.Show("Tên đăng nhập quá dài");
        }
    }
}
