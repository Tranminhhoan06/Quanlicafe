using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quanlicafe.DAO;
using Quanlicafe.DTO;

namespace Quanlicafe
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();

        }


        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        private void ThôngtinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile f = new fProfile();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.ShowDialog();

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
                lsvBill.Items.Add(lsvitem);
            }

        }



        void LoadSP()
        {
            string query = "SELECT NUOCUONG.NAME FROM dbo.NUOCUONG";
            cbCafe.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BillDAO.Instance.GetBill(1);
            Bill(1);
        }
    }
}
