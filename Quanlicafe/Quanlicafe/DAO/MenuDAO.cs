using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quanlicafe.DTO;
using System.Data;

namespace Quanlicafe.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> Getlistmenu(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            string query = "SELECT f.NAME,bi.SL,bi.SL*f.PRICE As Total FROM dbo.CHITIETHOADON As bi, dbo.HOADON As b, dbo.NUOCUONG AS f WHERE bi.IDBILL = b.IDHD AND bi.IDSP = f.IDSP AND b.IDHD = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }
    }
}
