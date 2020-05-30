using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Quanlicafe.DTO
{
    public class Bill
    {
        public Bill(int IDHD, DateTime? DATEIN)
        {
            this.ID = IDHD;
            this.DATEIN = DATEIN;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["IDHD"];
            this.DATEIN = (DateTime)row["DATEIN"];
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
