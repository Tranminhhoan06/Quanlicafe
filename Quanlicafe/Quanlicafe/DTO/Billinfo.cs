using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlicafe.DTO
{
    public class Billinfo
    {
        public Billinfo(int id, int idbill, int idsp, int sl)
        {
            this.IDCT = id;
            this.IDBILL = idbill;
            this.IDSP = idsp;
            this.SL = sl;
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
}}
}

