namespace QLCafe.View
{
    partial class frmDanhMuc
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
            dgvDanhMuc = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            btnCancel = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtMaDanhMuc = new TextBox();
            label1 = new Label();
            txtTenDanhMuc = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvDanhMuc.Location = new Point(47, 151);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 29;
            dgvDanhMuc.Size = new Size(385, 188);
            dgvDanhMuc.TabIndex = 0;
            dgvDanhMuc.CellContentClick += dgvDanhMuc_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Danh Mục";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Danh Mục";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(376, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 30;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(262, 437);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(111, 437);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 28;
            btnFind.Text = "Tìm ";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(338, 366);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(190, 366);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 26;
            btnEdit.Text = "Sửa ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(47, 366);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMaDanhMuc
            // 
            txtMaDanhMuc.Location = new Point(209, 55);
            txtMaDanhMuc.Name = "txtMaDanhMuc";
            txtMaDanhMuc.PlaceholderText = "Mã danh mục...";
            txtMaDanhMuc.Size = new Size(170, 27);
            txtMaDanhMuc.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 58);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã Danh Mục:";
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.Location = new Point(209, 98);
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.PlaceholderText = "Tên danh mục...";
            txtTenDanhMuc.Size = new Size(170, 27);
            txtTenDanhMuc.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 101);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 33;
            label2.Text = "Tên Danh Mục:";
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 495);
            Controls.Add(txtTenDanhMuc);
            Controls.Add(label2);
            Controls.Add(txtMaDanhMuc);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvDanhMuc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDanhMuc";
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhMuc;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnExit;
        private Button btnCancel;
        private Button btnFind;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtMaDanhMuc;
        private Label label1;
        private TextBox txtTenDanhMuc;
        private Label label2;
    }
}