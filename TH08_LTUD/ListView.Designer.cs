namespace DocDuLieuDB
{
    partial class frmLv
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
            this.btnCmbExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMonHoc = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCmbExit
            // 
            this.btnCmbExit.Location = new System.Drawing.Point(265, 185);
            this.btnCmbExit.Name = "btnCmbExit";
            this.btnCmbExit.Size = new System.Drawing.Size(75, 30);
            this.btnCmbExit.TabIndex = 6;
            this.btnCmbExit.Text = "Thoát";
            this.btnCmbExit.UseVisualStyleBackColor = true;
            this.btnCmbExit.Click += new System.EventHandler(this.btnCmbExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sách Môn Hoc";
            // 
            // lvMonHoc
            // 
            this.lvMonHoc.Location = new System.Drawing.Point(93, 68);
            this.lvMonHoc.Name = "lvMonHoc";
            this.lvMonHoc.Size = new System.Drawing.Size(250, 95);
            this.lvMonHoc.TabIndex = 7;
            this.lvMonHoc.UseCompatibleStateImageBehavior = false;
            // 
            // frmLv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.lvMonHoc);
            this.Controls.Add(this.btnCmbExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCmbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMonHoc;
    }
}