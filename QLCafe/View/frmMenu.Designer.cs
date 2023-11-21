namespace QLCafe.View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mónToolStripMenuItem1 = new ToolStripMenuItem();
            danhMụcToolStripMenuItem1 = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem1 = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, hóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mónToolStripMenuItem1, danhMụcToolStripMenuItem1, tàiKhoảnToolStripMenuItem1 });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(102, 32);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mónToolStripMenuItem1
            // 
            mónToolStripMenuItem1.Name = "mónToolStripMenuItem1";
            mónToolStripMenuItem1.Size = new Size(195, 32);
            mónToolStripMenuItem1.Text = "Món";
            mónToolStripMenuItem1.Click += mónToolStripMenuItem1_Click;
            // 
            // danhMụcToolStripMenuItem1
            // 
            danhMụcToolStripMenuItem1.Name = "danhMụcToolStripMenuItem1";
            danhMụcToolStripMenuItem1.Size = new Size(195, 32);
            danhMụcToolStripMenuItem1.Text = "Danh Mục";
            danhMụcToolStripMenuItem1.Click += danhMụcToolStripMenuItem1_Click;
            // 
            // tàiKhoảnToolStripMenuItem1
            // 
            tàiKhoảnToolStripMenuItem1.Name = "tàiKhoảnToolStripMenuItem1";
            tàiKhoảnToolStripMenuItem1.Size = new Size(195, 32);
            tàiKhoảnToolStripMenuItem1.Text = "Tài Khoản";
            tàiKhoảnToolStripMenuItem1.Click += tàiKhoảnToolStripMenuItem1_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phiếuNhậpToolStripMenuItem });
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(110, 32);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(204, 32);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            phiếuNhậpToolStripMenuItem.Click += phiếuNhậpToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 36);
            label1.Name = "label1";
            label1.Size = new Size(800, 414);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ CAFE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mónToolStripMenuItem1;
        private ToolStripMenuItem danhMụcToolStripMenuItem1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem1;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
    }
}