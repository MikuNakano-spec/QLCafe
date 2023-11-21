namespace QLCafe.View
{
    partial class frmTaiKhoan
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
            txtTenTaiKhoan = new TextBox();
            label2 = new Label();
            txtMaTaiKhoan = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            btnCancel = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvTaiKhoan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtMatKhau = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(295, 74);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.PlaceholderText = "Tên tài khoản...";
            txtTenTaiKhoan.Size = new Size(357, 27);
            txtTenTaiKhoan.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(154, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 26;
            label2.Text = "Tên Tài Khoản:";
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Location = new Point(295, 30);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.PlaceholderText = "Mã tài khoản...";
            txtMaTaiKhoan.Size = new Size(357, 27);
            txtMaTaiKhoan.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 33);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 24;
            label1.Text = "Mã Tài Khoản:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 23;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(643, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(498, 392);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 21;
            btnFind.Text = "Tìm ";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(357, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(195, 392);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Sửa ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.BackgroundColor = SystemColors.Control;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvTaiKhoan.Location = new Point(21, 175);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 29;
            dgvTaiKhoan.Size = new Size(767, 188);
            dgvTaiKhoan.TabIndex = 16;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Tài Khoản";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Tài Khoản";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 270;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mật Khẩu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 270;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(295, 118);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu...";
            txtMatKhau.Size = new Size(357, 27);
            txtMatKhau.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(154, 121);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 28;
            label3.Text = "Mật Khẩu:";
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label2);
            Controls.Add(txtMaTaiKhoan);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvTaiKhoan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenTaiKhoan;
        private Label label2;
        private TextBox txtMaTaiKhoan;
        private Label label1;
        private Button btnExit;
        private Button btnCancel;
        private Button btnFind;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvTaiKhoan;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtMatKhau;
        private Label label3;
    }
}