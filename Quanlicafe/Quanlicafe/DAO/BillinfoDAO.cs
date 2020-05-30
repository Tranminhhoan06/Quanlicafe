using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quanlicafe.DTO;
using System.Data;

namespace Quanlicafe.DAO
{
    public class BillinfoDAO
    {
        private static BillinfoDAO instance;
        public static BillinfoDAO Instance
        {
            get { if (instance == null) instance = new BillinfoDAO(); return BillinfoDAO.instance; }
            private set { BillinfoDAO.instance = value; }
        }
        private BillinfoDAO() { }
        public List<Billinfo> Getlist(int id)
        {
            List<Billinfo> Listbillinfo = new List<Billinfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON WHERE HOADON.IDHD = " + id);
            foreach (DataRow item in data.Rows)
            {
                Billinfo info = new Billinfo(item);
                Listbillinfo.Add(info);
            }
            return Listbillinfo;
        }
    }
}
