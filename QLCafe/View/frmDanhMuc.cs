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
    public partial class frmDanhMuc : Form
    {
        DanhMucController DanhMucController;
        List<DanhMuc> dsDanhMuc;
        public frmDanhMuc()
        {
            InitializeComponent();
            DanhMucController = new DanhMucController();
        }

        public void btnShow_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.Rows.Clear();
            dsDanhMuc = DanhMucController.Load();
            foreach (DanhMuc DanhMuc in dsDanhMuc)
            {
                string[] row = { DanhMuc.getMaDanhMuc(), DanhMuc.getTenDanhMuc() };
                dgvDanhMuc.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text)
               || string.IsNullOrEmpty(txtTenDanhMuc.Text)
               || txtMaDanhMuc.Text == ""
               || txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaDanhMuc.Focus();
                return;
            }
            DanhMuc DanhMuc = new DanhMuc();
            DanhMuc.setMaDanhMuc(txtMaDanhMuc.Text);
            DanhMuc.setTenDanhMuc(txtTenDanhMuc.Text);
            DanhMucController.Insert(DanhMuc);
            btnShow_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text)
               || string.IsNullOrEmpty(txtTenDanhMuc.Text)
               || txtMaDanhMuc.Text == ""
               || txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaDanhMuc.Focus();
                return;
            }
            DanhMuc DanhMuc = new DanhMuc();
            DanhMuc.setMaDanhMuc(txtMaDanhMuc.Text);
            DanhMuc.setTenDanhMuc(txtTenDanhMuc.Text);
            DanhMucController.Edit(DanhMuc);
            btnShow_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text))
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
            DanhMuc DanhMuc = new DanhMuc();
            DanhMuc.setMaDanhMuc(txtMaDanhMuc.Text);
            DanhMucController.Delete(DanhMuc);
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            btnShow_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text))
            {
                MessageBox.Show("Nhập mã danh mục để tìm");
                txtMaDanhMuc.Focus();
                return;
            }
            dgvDanhMuc.Rows.Clear();
            DanhMuc DanhMuc = new DanhMuc();
            DanhMuc.setMaDanhMuc(txtMaDanhMuc.Text);
            dsDanhMuc = DanhMucController.Find(DanhMuc);
            foreach (DanhMuc dm in dsDanhMuc)
            {
                string[] row = { dm.getMaDanhMuc(), dm.getTenDanhMuc() };
                dgvDanhMuc.Rows.Add(row);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            btnShow_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDanhMuc.Rows[e.RowIndex];
                txtMaDanhMuc.Text = row.Cells[0].Value.ToString();
                txtTenDanhMuc.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
