namespace QLCafe.View
{
    partial class frmDoAn
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
            dgvDoAn = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            label1 = new Label();
            txtMaDoAn = new TextBox();
            txtTenDoAn = new TextBox();
            label2 = new Label();
            txtSoLuong = new TextBox();
            label3 = new Label();
            txtGiaTien = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoAn).BeginInit();
            SuspendLayout();
            // 
            // dgvDoAn
            // 
            dgvDoAn.BackgroundColor = SystemColors.Control;
            dgvDoAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoAn.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDoAn.Location = new Point(21, 178);
            dgvDoAn.Name = "dgvDoAn";
            dgvDoAn.RowHeadersWidth = 51;
            dgvDoAn.RowTemplate.Height = 29;
            dgvDoAn.Size = new Size(767, 188);
            dgvDoAn.TabIndex = 0;
            dgvDoAn.CellContentClick += dgvDoAn_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Đồ Ăn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Đồ Ăn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số Lượng ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá Tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 180;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(46, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(201, 394);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(364, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(525, 394);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 5;
            btnFind.Text = "Tìm ";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(673, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 69);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã Đồ Ăn:";
            // 
            // txtMaDoAn
            // 
            txtMaDoAn.Location = new Point(187, 66);
            txtMaDoAn.Name = "txtMaDoAn";
            txtMaDoAn.PlaceholderText = "Mã đồ ăn...";
            txtMaDoAn.Size = new Size(170, 27);
            txtMaDoAn.TabIndex = 9;
            // 
            // txtTenDoAn
            // 
            txtTenDoAn.Location = new Point(187, 111);
            txtTenDoAn.Name = "txtTenDoAn";
            txtTenDoAn.PlaceholderText = "Tên đồ ăn...";
            txtTenDoAn.Size = new Size(170, 27);
            txtTenDoAn.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 114);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên Đồ Ăn:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(535, 66);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Số lượng...";
            txtSoLuong.Size = new Size(149, 27);
            txtSoLuong.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(454, 69);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Số Lượng:";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(535, 111);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.PlaceholderText = "Giá tiền...";
            txtGiaTien.Size = new Size(149, 27);
            txtGiaTien.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(454, 114);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 14;
            label4.Text = "Giá Tiền:";
            // 
            // frmDoAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(810, 463);
            Controls.Add(txtGiaTien);
            Controls.Add(label4);
            Controls.Add(txtSoLuong);
            Controls.Add(label3);
            Controls.Add(txtTenDoAn);
            Controls.Add(label2);
            Controls.Add(txtMaDoAn);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvDoAn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDoAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDoAn";
            ((System.ComponentModel.ISupportInitialize)dgvDoAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoAn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFind;
        private Button btnCancel;
        private Button btnExit;
        private Label label1;
        private TextBox txtMaDoAn;
        private TextBox txtTenDoAn;
        private Label label2;
        private TextBox txtSoLuong;
        private Label label3;
        private TextBox txtGiaTien;
        private Label label4;
    }
}