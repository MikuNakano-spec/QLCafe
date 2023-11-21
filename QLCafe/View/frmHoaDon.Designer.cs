namespace QLCafe.View
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvHoaDon = new DataGridView();
            maDoAn = new DataGridViewComboBoxColumn();
            tenDoAn = new DataGridViewTextBoxColumn();
            maDanhMuc = new DataGridViewTextBoxColumn();
            tenDanhMuc = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            giaTien = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtMaHoaDon = new TextBox();
            txtTenNguoiNhap = new TextBox();
            label3 = new Label();
            txtMaTaiKhoan = new TextBox();
            label4 = new Label();
            txtTenTaiKhoan = new TextBox();
            label5 = new Label();
            txtNgayHoaDon = new TextBox();
            label6 = new Label();
            btnCancel = new Button();
            btnExit = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { maDoAn, tenDoAn, maDanhMuc, tenDanhMuc, soLuong, giaTien, Column7 });
            dgvHoaDon.Location = new Point(12, 216);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(930, 157);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellValueChanged += dgvHoaDon_CellValueChanged;
            dgvHoaDon.CurrentCellDirtyStateChanged += dgvHoaDon_CurrentCellDirtyStateChanged;
            // 
            // maDoAn
            // 
            maDoAn.HeaderText = "Mã Đồ Ăn";
            maDoAn.MinimumWidth = 6;
            maDoAn.Name = "maDoAn";
            maDoAn.Resizable = DataGridViewTriState.True;
            maDoAn.SortMode = DataGridViewColumnSortMode.Automatic;
            maDoAn.Width = 125;
            // 
            // tenDoAn
            // 
            tenDoAn.HeaderText = "Tên Đồ Ăn";
            tenDoAn.MinimumWidth = 6;
            tenDoAn.Name = "tenDoAn";
            tenDoAn.Width = 125;
            // 
            // maDanhMuc
            // 
            maDanhMuc.HeaderText = "Mã Danh Mục";
            maDanhMuc.MinimumWidth = 6;
            maDanhMuc.Name = "maDanhMuc";
            maDanhMuc.Width = 125;
            // 
            // tenDanhMuc
            // 
            tenDanhMuc.HeaderText = "Tên Danh Mục";
            tenDanhMuc.MinimumWidth = 6;
            tenDanhMuc.Name = "tenDanhMuc";
            tenDanhMuc.Width = 125;
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số Lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.Width = 125;
            // 
            // giaTien
            // 
            giaTien.HeaderText = "Giá Tiền";
            giaTien.MinimumWidth = 6;
            giaTien.Name = "giaTien";
            giaTien.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Thành Tiền";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 41);
            label1.TabIndex = 1;
            label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 77);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã Hóa Đơn:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(230, 74);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.PlaceholderText = "Mã hóa đơn...";
            txtMaHoaDon.Size = new Size(227, 27);
            txtMaHoaDon.TabIndex = 3;
            txtMaHoaDon.TextChanged += txtMaHoaDon_TextChanged;
            // 
            // txtTenNguoiNhap
            // 
            txtTenNguoiNhap.Location = new Point(230, 119);
            txtTenNguoiNhap.Name = "txtTenNguoiNhap";
            txtTenNguoiNhap.PlaceholderText = "Tên người nhập...";
            txtTenNguoiNhap.Size = new Size(227, 27);
            txtTenNguoiNhap.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 126);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên Người Nhập:";
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Location = new Point(642, 71);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.PlaceholderText = "Mã tài khoản...";
            txtMaTaiKhoan.Size = new Size(207, 27);
            txtMaTaiKhoan.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(505, 74);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Mã Tài Khoản:";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(642, 119);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.PlaceholderText = "Tên tài khoản...";
            txtTenTaiKhoan.Size = new Size(207, 27);
            txtTenTaiKhoan.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(505, 122);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 8;
            label5.Text = "Tên Tài Khoản:";
            // 
            // txtNgayHoaDon
            // 
            txtNgayHoaDon.Location = new Point(230, 165);
            txtNgayHoaDon.Name = "txtNgayHoaDon";
            txtNgayHoaDon.PlaceholderText = "Ngày hóa đơn... (dd/mm/yy)";
            txtNgayHoaDon.Size = new Size(227, 27);
            txtNgayHoaDon.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(74, 172);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 10;
            label6.Text = "Ngày Hóa Đơn:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(625, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(795, 401);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(25, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 63);
            btnSave.TabIndex = 14;
            btnSave.Text = "Thanh Toán";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(942, 459);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(txtNgayHoaDon);
            Controls.Add(label6);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label5);
            Controls.Add(txtMaTaiKhoan);
            Controls.Add(label4);
            Controls.Add(txtTenNguoiNhap);
            Controls.Add(label3);
            Controls.Add(txtMaHoaDon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHoaDon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHoaDon";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvHoaDon;
        private Label label1;
        private Label label2;
        private TextBox txtMaHoaDon;
        private TextBox txtTenNguoiNhap;
        private Label label3;
        private TextBox txtMaTaiKhoan;
        private Label label4;
        private TextBox txtTenTaiKhoan;
        private Label label5;
        private TextBox txtNgayHoaDon;
        private Label label6;
        private Button btnCancel;
        private Button btnExit;
        private Button btnSave;
        private DataGridViewComboBoxColumn maDoAn;
        private DataGridViewTextBoxColumn tenDoAn;
        private DataGridViewTextBoxColumn maDanhMuc;
        private DataGridViewTextBoxColumn tenDanhMuc;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn giaTien;
        private DataGridViewTextBoxColumn Column7;
    }
}