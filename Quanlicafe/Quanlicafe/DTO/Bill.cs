using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Quanlicafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? datein)
        {
            this.ID = id;
            this.DATEIN = datein;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DATEIN = (DateTime)row["datein"];
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private DateTime? dATEIN;
        public DateTime? DATEIN
        {
            get { return dATEIN; }
            set { dATEIN = value; }
        }
    }

}
