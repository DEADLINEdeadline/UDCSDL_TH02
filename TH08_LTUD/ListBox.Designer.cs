﻿namespace DocDuLieuDB
{
    partial class frmLb
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCmbExit = new System.Windows.Forms.Button();
            this.lbMonHoc = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btnCmbExit
            // 
            this.btnCmbExit.Location = new System.Drawing.Point(265, 185);
            this.btnCmbExit.Name = "btnCmbExit";
            this.btnCmbExit.Size = new System.Drawing.Size(75, 30);
            this.btnCmbExit.TabIndex = 5;
            this.btnCmbExit.Text = "Thoát";
            this.btnCmbExit.UseVisualStyleBackColor = true;
            this.btnCmbExit.Click += new System.EventHandler(this.btnCmbExit_Click);
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.FormattingEnabled = true;
            this.lbMonHoc.Location = new System.Drawing.Point(93, 74);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(250, 95);
            this.lbMonHoc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Sách Môn Hoc";
            // 
            // frmLb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.lbMonHoc);
            this.Controls.Add(this.btnCmbExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCmbExit;
        private System.Windows.Forms.ListBox lbMonHoc;
        private System.Windows.Forms.Label label2;
    }
}