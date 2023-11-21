using QLCafe.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCafe.Controller;
using QLCafe.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLCafe.View
{
    public partial class frmDoAn : Form
    {
        DoAnController DoAnController;
        List<DoAn> dsDoAn;
        public frmDoAn()
        {
            InitializeComponent();
            DoAnController = new DoAnController();
        }

        public void btnShow_Click(object sender, EventArgs e)
        {
            dgvDoAn.Rows.Clear();
            dsDoAn = DoAnController.Load();
            foreach (DoAn DoAn in dsDoAn)
            {
                string[] row = { DoAn.getMaDoAn(), DoAn.getTenDoAn(), DoAn.getSoLuong().ToString(), DoAn.getGiaTien().ToString() };
                dgvDoAn.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDoAn.Text)
               || string.IsNullOrEmpty(txtTenDoAn.Text)
               || string.IsNullOrEmpty(txtSoLuong.Text)
               || string.IsNullOrEmpty(txtGiaTien.Text)
               || txtMaDoAn.Text == ""
               || txtTenDoAn.Text == ""
               || txtSoLuong.Text == ""
               || txtGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaDoAn.Focus();
                return;
            }
            DoAn DoAn = new DoAn();
            DoAn.setMaDoAn(txtMaDoAn.Text);
            DoAn.setTenDoAn(txtTenDoAn.Text);
            DoAn.setSoLuong(int.Parse(txtSoLuong.Text));
            DoAn.setGiaTien(float.Parse(txtGiaTien.Text));
            DoAnController.Insert(DoAn);
            btnShow_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDoAn.Text)
               || string.IsNullOrEmpty(txtTenDoAn.Text)
               || string.IsNullOrEmpty(txtSoLuong.Text)
               || string.IsNullOrEmpty(txtGiaTien.Text)
               || txtMaDoAn.Text == ""
               || txtTenDoAn.Text == ""
               || txtSoLuong.Text == ""
               || txtGiaTien.Text == "")
            {
                MessageBox.Show("Không có thông tin để sửa");
                txtMaDoAn.Focus();
                return;
            }
            DoAn DoAn = new DoAn();
            DoAn.setMaDoAn(txtMaDoAn.Text);
            DoAn.setTenDoAn(txtTenDoAn.Text);
            DoAn.setSoLuong(int.Parse(txtSoLuong.Text));
            DoAn.setGiaTien(float.Parse(txtGiaTien.Text));
            DoAnController.Edit(DoAn);
            btnShow_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDoAn.Text))
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
            DoAn DoAn = new DoAn();
            DoAn.setMaDoAn(txtMaDoAn.Text);
            DoAnController.Delete(DoAn);
            txtMaDoAn.Clear();
            txtTenDoAn.Clear();
            txtSoLuong.Clear();
            txtGiaTien.Clear();
            btnShow_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDoAn.Text))
            {
                MessageBox.Show("Nhập mã đồ ăn để tìm");
                txtMaDoAn.Focus();
                return;
            }
            dgvDoAn.Rows.Clear();
            DoAn DoAn = new DoAn();
            DoAn.setMaDoAn(txtMaDoAn.Text);
            dsDoAn = DoAnController.Find(DoAn);
            foreach (DoAn d in dsDoAn)
            {
                string[] row = { d.getMaDoAn(), d.getTenDoAn(), d.getSoLuong().ToString(), d.getGiaTien().ToString() };
                dgvDoAn.Rows.Add(row);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaDoAn.Clear();
            txtTenDoAn.Clear();
            txtSoLuong.Clear();
            txtGiaTien.Clear();
            btnShow_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }

        private void dgvDoAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDoAn.Rows[e.RowIndex];
                txtMaDoAn.Text = row.Cells[0].Value.ToString();
                txtTenDoAn.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtGiaTien.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
