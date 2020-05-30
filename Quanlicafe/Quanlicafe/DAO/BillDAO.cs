using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Quanlicafe.DTO;

namespace Quanlicafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetBill(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON WHERE HOADON.IDHD = " + id);
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            else
                return -1;
        }
    }
}
