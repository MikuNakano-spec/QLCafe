using QLCafe.Controller;
using QLCafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLCafe.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoAn frmDoAn = new frmDoAn();
            this.Hide();
            frmDoAn.btnShow_Click(sender, e);
            frmDoAn.Show();
        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDanhMuc = new frmDanhMuc();
            this.Hide();
            frmDanhMuc.btnShow_Click(sender, e);
            frmDanhMuc.Show();
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            this.Hide();
            frmTaiKhoan.btnShow_Click(sender, e);
            frmTaiKhoan.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();

            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)frmHoaDon.dgvHoaDon.Columns["maDoAn"];
            HoaDonController HDController = new HoaDonController();
            List<DoAn> DoAn = HDController.Combobox();

            foreach (DoAn da in DoAn)
            {
                string MaDonAn = da.getMaDoAn();
                combo.Items.Add(MaDonAn);
            }


            this.Hide();
            frmHoaDon.Show();
        }
    }
}
