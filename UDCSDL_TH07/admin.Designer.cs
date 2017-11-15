namespace Login
{
    partial class frmAdmin
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.tpSanPham = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPriceSanPham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNameSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtIdSanPham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSearchSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnViewSanPham = new System.Windows.Forms.Button();
            this.btnEditSanPham = new System.Windows.Forms.Button();
            this.btnDelSanPham = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnViewNhanVien = new System.Windows.Forms.Button();
            this.btnEditNhanVien = new System.Windows.Forms.Button();
            this.btnDeleteNhanVien = new System.Windows.Forms.Button();
            this.btnAddNhanVien = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtSearchNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddSanPham = new System.Windows.Forms.Button();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbStaff = new System.Windows.Forms.RadioButton();
            this.tabAdmin.SuspendLayout();
            this.tpNhanVien.SuspendLayout();
            this.tpSanPham.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tpNhanVien);
            this.tabAdmin.Controls.Add(this.tpSanPham);
            this.tabAdmin.Location = new System.Drawing.Point(-1, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(785, 560);
            this.tabAdmin.TabIndex = 0;
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.Controls.Add(this.panel3);
            this.tpNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVien.Size = new System.Drawing.Size(777, 534);
            this.tpNhanVien.TabIndex = 0;
            this.tpNhanVien.Text = "Danh Sách Nhân Viên";
            this.tpNhanVien.UseVisualStyleBackColor = true;
            // 
            // tpSanPham
            // 
            this.tpSanPham.Controls.Add(this.panel1);
            this.tpSanPham.Location = new System.Drawing.Point(4, 22);
            this.tpSanPham.Name = "tpSanPham";
            this.tpSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tpSanPham.Size = new System.Drawing.Size(777, 534);
            this.tpSanPham.TabIndex = 1;
            this.tpSanPham.Text = "Danh Sách Sản Phẩm";
            this.tpSanPham.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(390, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 495);
            this.panel4.TabIndex = 12;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtPriceSanPham);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Location = new System.Drawing.Point(1, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(383, 36);
            this.panel11.TabIndex = 5;
            // 
            // txtPriceSanPham
            // 
            this.txtPriceSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceSanPham.Location = new System.Drawing.Point(134, 4);
            this.txtPriceSanPham.Name = "txtPriceSanPham";
            this.txtPriceSanPham.Size = new System.Drawing.Size(246, 26);
            this.txtPriceSanPham.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtNameSanPham);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(1, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 36);
            this.panel6.TabIndex = 4;
            // 
            // txtNameSanPham
            // 
            this.txtNameSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSanPham.Location = new System.Drawing.Point(134, 4);
            this.txtNameSanPham.Name = "txtNameSanPham";
            this.txtNameSanPham.Size = new System.Drawing.Size(246, 26);
            this.txtNameSanPham.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sản phẩm";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtIdSanPham);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(1, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(383, 36);
            this.panel7.TabIndex = 3;
            // 
            // txtIdSanPham
            // 
            this.txtIdSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSanPham.Location = new System.Drawing.Point(134, 4);
            this.txtIdSanPham.Name = "txtIdSanPham";
            this.txtIdSanPham.ReadOnly = true;
            this.txtIdSanPham.Size = new System.Drawing.Size(246, 26);
            this.txtIdSanPham.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.ColumnHeadersVisible = false;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(388, 499);
            this.dgvSanPham.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtSearchSanPham);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(390, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(387, 36);
            this.panel8.TabIndex = 14;
            // 
            // txtSearchSanPham
            // 
            this.txtSearchSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSanPham.Location = new System.Drawing.Point(135, 4);
            this.txtSearchSanPham.Name = "txtSearchSanPham";
            this.txtSearchSanPham.Size = new System.Drawing.Size(246, 26);
            this.txtSearchSanPham.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnViewSanPham);
            this.panel9.Controls.Add(this.btnEditSanPham);
            this.panel9.Controls.Add(this.btnDelSanPham);
            this.panel9.Controls.Add(this.btnAddSanPham);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(388, 36);
            this.panel9.TabIndex = 13;
            // 
            // btnViewSanPham
            // 
            this.btnViewSanPham.Location = new System.Drawing.Point(309, 3);
            this.btnViewSanPham.Name = "btnViewSanPham";
            this.btnViewSanPham.Size = new System.Drawing.Size(75, 30);
            this.btnViewSanPham.TabIndex = 4;
            this.btnViewSanPham.Text = "Xem";
            this.btnViewSanPham.UseVisualStyleBackColor = true;
            // 
            // btnEditSanPham
            // 
            this.btnEditSanPham.Location = new System.Drawing.Point(211, 3);
            this.btnEditSanPham.Name = "btnEditSanPham";
            this.btnEditSanPham.Size = new System.Drawing.Size(75, 30);
            this.btnEditSanPham.TabIndex = 3;
            this.btnEditSanPham.Text = "Sửa";
            this.btnEditSanPham.UseVisualStyleBackColor = true;
            // 
            // btnDelSanPham
            // 
            this.btnDelSanPham.Location = new System.Drawing.Point(109, 3);
            this.btnDelSanPham.Name = "btnDelSanPham";
            this.btnDelSanPham.Size = new System.Drawing.Size(75, 30);
            this.btnDelSanPham.TabIndex = 2;
            this.btnDelSanPham.Text = "Xóa";
            this.btnDelSanPham.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 533);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSanPham);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 492);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel16);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 533);
            this.panel3.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvAccount);
            this.panel5.Location = new System.Drawing.Point(0, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 492);
            this.panel5.TabIndex = 15;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.Size = new System.Drawing.Size(388, 499);
            this.dgvAccount.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel18);
            this.panel10.Controls.Add(this.panel17);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Location = new System.Drawing.Point(390, 39);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(387, 495);
            this.panel10.TabIndex = 12;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtUsername);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Location = new System.Drawing.Point(3, 45);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(383, 36);
            this.panel12.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(134, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 26);
            this.txtUsername.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtDisplayName);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Location = new System.Drawing.Point(3, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(383, 36);
            this.panel13.TabIndex = 4;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(134, 4);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(246, 26);
            this.txtDisplayName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnViewNhanVien);
            this.panel15.Controls.Add(this.btnEditNhanVien);
            this.panel15.Controls.Add(this.btnDeleteNhanVien);
            this.panel15.Controls.Add(this.btnAddNhanVien);
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(388, 36);
            this.panel15.TabIndex = 13;
            // 
            // btnViewNhanVien
            // 
            this.btnViewNhanVien.Location = new System.Drawing.Point(309, 3);
            this.btnViewNhanVien.Name = "btnViewNhanVien";
            this.btnViewNhanVien.Size = new System.Drawing.Size(75, 30);
            this.btnViewNhanVien.TabIndex = 4;
            this.btnViewNhanVien.Text = "Xem";
            this.btnViewNhanVien.UseVisualStyleBackColor = true;
            this.btnViewNhanVien.Click += new System.EventHandler(this.btnViewNhanVien_Click);
            // 
            // btnEditNhanVien
            // 
            this.btnEditNhanVien.Location = new System.Drawing.Point(211, 3);
            this.btnEditNhanVien.Name = "btnEditNhanVien";
            this.btnEditNhanVien.Size = new System.Drawing.Size(75, 30);
            this.btnEditNhanVien.TabIndex = 3;
            this.btnEditNhanVien.Text = "Sửa";
            this.btnEditNhanVien.UseVisualStyleBackColor = true;
            this.btnEditNhanVien.Click += new System.EventHandler(this.btnEditNhanVien_Click);
            // 
            // btnDeleteNhanVien
            // 
            this.btnDeleteNhanVien.Location = new System.Drawing.Point(109, 3);
            this.btnDeleteNhanVien.Name = "btnDeleteNhanVien";
            this.btnDeleteNhanVien.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteNhanVien.TabIndex = 2;
            this.btnDeleteNhanVien.Text = "Xóa";
            this.btnDeleteNhanVien.UseVisualStyleBackColor = true;
            this.btnDeleteNhanVien.Click += new System.EventHandler(this.btnDeleteNhanVien_Click);
            // 
            // btnAddNhanVien
            // 
            this.btnAddNhanVien.Location = new System.Drawing.Point(4, 3);
            this.btnAddNhanVien.Name = "btnAddNhanVien";
            this.btnAddNhanVien.Size = new System.Drawing.Size(75, 30);
            this.btnAddNhanVien.TabIndex = 1;
            this.btnAddNhanVien.Text = "Thêm";
            this.btnAddNhanVien.UseVisualStyleBackColor = true;
            this.btnAddNhanVien.Click += new System.EventHandler(this.btnAddNhanVien_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtSearchNhanVien);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(390, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(387, 36);
            this.panel16.TabIndex = 14;
            // 
            // txtSearchNhanVien
            // 
            this.txtSearchNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNhanVien.Location = new System.Drawing.Point(135, 4);
            this.txtSearchNhanVien.Name = "txtSearchNhanVien";
            this.txtSearchNhanVien.Size = new System.Drawing.Size(246, 26);
            this.txtSearchNhanVien.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm kiếm";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtEmail);
            this.panel17.Controls.Add(this.label9);
            this.panel17.Location = new System.Drawing.Point(3, 87);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(383, 36);
            this.panel17.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.rdbStaff);
            this.panel18.Controls.Add(this.rdbAdmin);
            this.panel18.Controls.Add(this.label10);
            this.panel18.Location = new System.Drawing.Point(2, 129);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(383, 36);
            this.panel18.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chức Vụ";
            // 
            // btnAddSanPham
            // 
            this.btnAddSanPham.Location = new System.Drawing.Point(4, 3);
            this.btnAddSanPham.Name = "btnAddSanPham";
            this.btnAddSanPham.Size = new System.Drawing.Size(75, 30);
            this.btnAddSanPham.TabIndex = 1;
            this.btnAddSanPham.Text = "Thêm";
            this.btnAddSanPham.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(135, 9);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbAdmin.TabIndex = 10;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbStaff
            // 
            this.rdbStaff.AutoSize = true;
            this.rdbStaff.Checked = true;
            this.rdbStaff.Location = new System.Drawing.Point(244, 9);
            this.rdbStaff.Name = "rdbStaff";
            this.rdbStaff.Size = new System.Drawing.Size(47, 17);
            this.rdbStaff.TabIndex = 11;
            this.rdbStaff.TabStop = true;
            this.rdbStaff.Text = "Staff";
            this.rdbStaff.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.tabAdmin.ResumeLayout(false);
            this.tpNhanVien.ResumeLayout(false);
            this.tpSanPham.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tpNhanVien;
        private System.Windows.Forms.TabPage tpSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtPriceSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNameSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtIdSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnViewSanPham;
        private System.Windows.Forms.Button btnEditSanPham;
        private System.Windows.Forms.Button btnDelSanPham;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtSearchSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnViewNhanVien;
        private System.Windows.Forms.Button btnEditNhanVien;
        private System.Windows.Forms.Button btnDeleteNhanVien;
        private System.Windows.Forms.Button btnAddNhanVien;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtSearchNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddSanPham;
        private System.Windows.Forms.RadioButton rdbStaff;
        private System.Windows.Forms.RadioButton rdbAdmin;
    }
}