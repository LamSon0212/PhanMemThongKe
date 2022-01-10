using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanMemThongKe
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void chagePassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            frm_DonHangMain frm_DonHangMain = new frm_DonHangMain()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frm_DonHangMain.FormBorderStyle = FormBorderStyle.None;
            TabDonHang.Controls.Add(frm_DonHangMain);
            frm_DonHangMain.Show();
        }
    }
}
