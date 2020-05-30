using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Quanlicafe.DTO
{
    public class Menu
    {
        public Menu(string NAME, int SL, int Total = 0)
        {
            this.NAME = NAME;
            this.SL = SL;
            this.Total = Total;
        }
        public Menu(DataRow row)
        {
            this.NAME = row["NAME"].ToString();
            this.SL = (int)row["SL"];
            this.Total = (int)row["Total"];
        }
        private int thanhtien;


        public int Total
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        private int count;


        public int SL
        {
            get { return count; }
            set { count = value; }
        }
        private string name;



        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
    }
}
