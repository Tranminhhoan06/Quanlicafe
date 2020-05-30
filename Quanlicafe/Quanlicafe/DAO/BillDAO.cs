using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        //private BillDAO() { }
        //public int GetBill(int id)
        //{

        //}
    }
}
