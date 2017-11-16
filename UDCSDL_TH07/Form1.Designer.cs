namespace QuanLy
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIDangKi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmINhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmISanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIQuenMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmILienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHeThong,
            this.tsmDanhMuc,
            this.tsmHoaDon,
            this.tsmBaoCao,
            this.tsmTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmHeThong
            // 
            this.tsmHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIDangNhap,
            this.tsmIDangKi});
            this.tsmHeThong.Name = "tsmHeThong";
            this.tsmHeThong.Size = new System.Drawing.Size(72, 20);
            this.tsmHeThong.Text = "Hệ Thống";
            // 
            // tsmIDangNhap
            // 
            this.tsmIDangNhap.Name = "tsmIDangNhap";
            this.tsmIDangNhap.Size = new System.Drawing.Size(152, 22);
            this.tsmIDangNhap.Text = "Đăng nhập";
            this.tsmIDangNhap.Click += new System.EventHandler(this.tsmIDangNhap_Click);
            // 
            // tsmIDangKi
            // 
            this.tsmIDangKi.Name = "tsmIDangKi";
            this.tsmIDangKi.Size = new System.Drawing.Size(152, 22);
            this.tsmIDangKi.Text = "Đăng ký";
            this.tsmIDangKi.Click += new System.EventHandler(this.tsmIDangKi_Click);
            // 
            // tsmDanhMuc
            // 
            this.tsmDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmINhanVien,
            this.tsmISanPham});
            this.tsmDanhMuc.Name = "tsmDanhMuc";
            this.tsmDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.tsmDanhMuc.Text = "Danh mục";
            // 
            // tsmINhanVien
            // 
            this.tsmINhanVien.Name = "tsmINhanVien";
            this.tsmINhanVien.Size = new System.Drawing.Size(128, 22);
            this.tsmINhanVien.Text = "Nhân viên";
            // 
            // tsmISanPham
            // 
            this.tsmISanPham.Name = "tsmISanPham";
            this.tsmISanPham.Size = new System.Drawing.Size(128, 22);
            this.tsmISanPham.Text = "Sản phẩm";
            // 
            // tsmHoaDon
            // 
            this.tsmHoaDon.Name = "tsmHoaDon";
            this.tsmHoaDon.Size = new System.Drawing.Size(65, 20);
            this.tsmHoaDon.Text = "Hóa đơn";
            // 
            // tsmBaoCao
            // 
            this.tsmBaoCao.Name = "tsmBaoCao";
            this.tsmBaoCao.Size = new System.Drawing.Size(61, 20);
            this.tsmBaoCao.Text = "Báo cáo";
            // 
            // tsmTroGiup
            // 
            this.tsmTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIQuenMatKhau,
            this.tsmILienHe,
            this.tsmIDangXuat});
            this.tsmTroGiup.Name = "tsmTroGiup";
            this.tsmTroGiup.Size = new System.Drawing.Size(64, 20);
            this.tsmTroGiup.Text = "Trợ giúp";
            // 
            // tsmIQuenMatKhau
            // 
            this.tsmIQuenMatKhau.Name = "tsmIQuenMatKhau";
            this.tsmIQuenMatKhau.Size = new System.Drawing.Size(156, 22);
            this.tsmIQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // tsmILienHe
            // 
            this.tsmILienHe.Name = "tsmILienHe";
            this.tsmILienHe.Size = new System.Drawing.Size(156, 22);
            this.tsmILienHe.Text = "Liên hệ";
            // 
            // tsmIDangXuat
            // 
            this.tsmIDangXuat.Name = "tsmIDangXuat";
            this.tsmIDangXuat.Size = new System.Drawing.Size(156, 22);
            this.tsmIDangXuat.Text = "Đăng xuất";
            this.tsmIDangXuat.Click += new System.EventHandler(this.tsmIDangXuat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsmIDangNhap;
        private System.Windows.Forms.ToolStripMenuItem tsmIDangKi;
        private System.Windows.Forms.ToolStripMenuItem tsmDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmINhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmISanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tsmTroGiup;
        private System.Windows.Forms.ToolStripMenuItem tsmIQuenMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tsmILienHe;
        private System.Windows.Forms.ToolStripMenuItem tsmIDangXuat;
    }
}

