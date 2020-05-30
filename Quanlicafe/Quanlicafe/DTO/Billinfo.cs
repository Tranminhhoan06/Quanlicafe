using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Quanlicafe.DTO
{
    public class Billinfo
    {
        public Billinfo(int IDCT, int IDBILL, int IDSP, int SL)
        {
            this.IDCT = IDCT;
            this.IDBILL = IDBILL;
            this.IDSP = IDSP;
            this.SL = SL;
        }
        public Billinfo(DataRow row)
        {
            this.IDCT = (int)row["IDCT"];
            this.IDBILL = (int)row["IDBILL"];
            this.IDSP = (int)row["IDSP"];
            this.SL = (int)row["SL"];
        }

        private int sL;


        public int SL
        {
            get { return sL; }
            set { sL = value; }
        }private int iDSP;


        public int IDSP
        {
            get { return iDSP; }
            set { iDSP = value; }
        }private int iDBILL;


        public int IDBILL
        {
            get { return iDBILL; }
            set { iDBILL = value; }
        }private int iDCT;



        public int IDCT
        {
            get { return iDCT; }
            set { iDCT = value; }
        }
    }
}

