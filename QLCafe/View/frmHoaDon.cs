using PdfSharp.Drawing;
using PdfSharp.Pdf;
using QLCafe.Controller;
using QLCafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLCafe.View
{
    public partial class frmHoaDon : Form
    {
        HoaDonController HDController;
        List<DoAn> dsDoAn;
        public frmHoaDon()
        {
            InitializeComponent();
            HDController = new HoaDonController();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            HDController.Insert(txtMaHoaDon, dgvHoaDon);

            await HDController.Export(txtMaHoaDon, dgvHoaDon);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
            txtTenNguoiNhap.Clear();
            txtMaTaiKhoan.Clear();
            txtTenNguoiNhap.Clear();
            txtNgayHoaDon.Clear();
            dgvHoaDon.Rows.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            HoaDonController.HienThiCombobox(dgvHoaDon);
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            HoaDonController.HienThiPhieuNhap(txtMaHoaDon, txtTenNguoiNhap, txtMaTaiKhoan, txtTenTaiKhoan, txtNgayHoaDon);
        }

        private void dgvHoaDon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.IsCurrentCellDirty)
            {
                dgvHoaDon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
