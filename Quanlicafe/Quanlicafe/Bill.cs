using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlicafe.DTO;
using Quanlicafe.DAO;

namespace Quanlicafe
{
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }
        void Bill(int id)
        {
            List<Billinfo> Listbillinfo = BillinfoDAO.Instance.Getlist(BillDAO.Instance.GetBill(id));
            foreach (Billinfo item in Listbillinfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.IDCT.ToString());
                lsvitem.SubItems.Add(item.IDBILL.ToString());
                lsvitem.SubItems.Add(item.IDSP.ToString());
                lsvitem.SubItems.Add(item.SL.ToString());
                lsvTotalBill.Items.Add(lsvitem);
            }

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Bill(1);
        }


    }
}
