namespace AddDeleteSetting
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
            this.DanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.find = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.tinh = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachHang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DanhSachKhachHang
            // 
            this.DanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachKhachHang.Location = new System.Drawing.Point(12, 51);
            this.DanhSachKhachHang.Name = "DanhSachKhachHang";
            this.DanhSachKhachHang.Size = new System.Drawing.Size(319, 240);
            this.DanhSachKhachHang.TabIndex = 0;
            this.DanhSachKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachKhachHang_CellContentClick);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(12, 12);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(128, 20);
            this.find.TabIndex = 1;
            this.find.TextChanged += new System.EventHandler(this.find_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(399, 51);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(109, 20);
            this.id.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(399, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(109, 20);
            this.name.TabIndex = 3;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(399, 134);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(109, 20);
            this.sdt.TabIndex = 4;
            // 
            // tinh
            // 
            this.tinh.Location = new System.Drawing.Point(399, 176);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(109, 20);
            this.tinh.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(427, 296);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã KH: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên KH: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "SĐT KH: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tỉnh KH: ";
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(340, 217);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(84, 34);
            this.Them.TabIndex = 11;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(431, 217);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(84, 34);
            this.Xoa.TabIndex = 12;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(389, 257);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(84, 34);
            this.Sua.TabIndex = 13;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 301);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.find);
            this.Controls.Add(this.DanhSachKhachHang);
            this.Name = "Form1";
            this.Text = "Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachHang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DanhSachKhachHang;
        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox tinh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
    }
}

