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

namespace QLCafe.View
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanController TaiKhoanController;
        List<TaiKhoan> dsTaiKhoan;
        public frmTaiKhoan()
        {
            InitializeComponent();
            TaiKhoanController = new TaiKhoanController();
        }

        public void btnShow_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.Rows.Clear();
            dsTaiKhoan = TaiKhoanController.Load();
            foreach (TaiKhoan TaiKhoan in dsTaiKhoan)
            {
                string[] row = { TaiKhoan.getMaTaiKhoan(), TaiKhoan.getTenTaiKhoan(), TaiKhoan.getMatKhau() };
                dgvTaiKhoan.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiKhoan.Text)
               || string.IsNullOrEmpty(txtTenTaiKhoan.Text)
               || string.IsNullOrEmpty(txtMatKhau.Text)
               || txtMaTaiKhoan.Text == ""
               || txtTenTaiKhoan.Text == ""
               || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaTaiKhoan.Focus();
                return;
            }
            TaiKhoan TaiKhoan = new TaiKhoan();
            TaiKhoan.setMaTaiKhoan(txtMaTaiKhoan.Text);
            TaiKhoan.setTenTaiKhoan(txtTenTaiKhoan.Text);
            TaiKhoan.setMatKhau(txtMatKhau.Text);
            TaiKhoanController.Insert(TaiKhoan);
            btnShow_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiKhoan.Text)
               || string.IsNullOrEmpty(txtTenTaiKhoan.Text)
               || string.IsNullOrEmpty(txtMatKhau.Text)
               || txtMaTaiKhoan.Text == ""
               || txtTenTaiKhoan.Text == ""
               || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không có thông tin để sửa");
                txtMaTaiKhoan.Focus();
                return;
            }
            TaiKhoan TaiKhoan = new TaiKhoan();
            TaiKhoan.setMaTaiKhoan(txtMaTaiKhoan.Text);
            TaiKhoan.setTenTaiKhoan(txtTenTaiKhoan.Text);
            TaiKhoan.setMatKhau(txtMatKhau.Text);
            TaiKhoanController.Edit(TaiKhoan);
            btnShow_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiKhoan.Text))
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
            TaiKhoan TaiKhoan = new TaiKhoan();
            TaiKhoan.setMaTaiKhoan(txtMaTaiKhoan.Text);
            TaiKhoanController.Delete(TaiKhoan);
            txtMaTaiKhoan.Clear();
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            btnShow_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiKhoan.Text))
            {
                MessageBox.Show("Nhập mã tài khoản để tìm");
                txtMaTaiKhoan.Focus();
                return;
            }
            dgvTaiKhoan.Rows.Clear();
            TaiKhoan TaiKhoan = new TaiKhoan();
            TaiKhoan.setMaTaiKhoan(txtMaTaiKhoan.Text);
            dsTaiKhoan = TaiKhoanController.Find(TaiKhoan);
            foreach (TaiKhoan tk in dsTaiKhoan)
            {
                string[] row = { tk.getMaTaiKhoan(), tk.getTenTaiKhoan(), tk.getMatKhau() };
                dgvTaiKhoan.Rows.Add(row);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Clear();
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            btnShow_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells[0].Value.ToString();
                txtTenTaiKhoan.Text = row.Cells[1].Value.ToString();
                txtMatKhau.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
