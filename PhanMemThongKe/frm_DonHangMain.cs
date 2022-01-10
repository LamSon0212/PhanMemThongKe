using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhanMemThongKe
{
    public partial class frm_DonHangMain : DevExpress.XtraEditors.XtraForm
    {
        public frm_DonHangMain()
        {
            InitializeComponent();
        }
        private string query;
        private string fullPathIso;
        private DataTable DataIso;

        private void _Load()
        {
            string query = "SELECT * FROM dbo.ThongKeDonHang ";
            DataIso = DataProvider.Instance.ExecuteQuery(query);
            gridControl1.DataSource = DataIso;
        }

        private void frm_DonHangMain_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            //if (Temp.Upload == false)
            //{
            //    XtraMessageBox.Show("你沒有權限！");
            //    return;
            //}

            frm_UploadIso frm_UploadIso = new frm_UploadIso();
            frm_UploadIso.ShowDialog();
            frm_UploadIso.txbMaVanKien.ReadOnly = false;
            frm_UploadIso.plSuaBieuDonOk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            _Load();
        }
    }
}