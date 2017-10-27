namespace DocDuLieuDB
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
            this.btnCmb = new System.Windows.Forms.Button();
            this.btnLb = new System.Windows.Forms.Button();
            this.btnLv = new System.Windows.Forms.Button();
            this.btnDgv = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCmb
            // 
            this.btnCmb.Location = new System.Drawing.Point(90, 50);
            this.btnCmb.Name = "btnCmb";
            this.btnCmb.Size = new System.Drawing.Size(90, 50);
            this.btnCmb.TabIndex = 2;
            this.btnCmb.Text = "ComboBox";
            this.btnCmb.UseVisualStyleBackColor = true;
            this.btnCmb.Click += new System.EventHandler(this.btnCmb_Click);
            // 
            // btnLb
            // 
            this.btnLb.Location = new System.Drawing.Point(186, 50);
            this.btnLb.Name = "btnLb";
            this.btnLb.Size = new System.Drawing.Size(90, 50);
            this.btnLb.TabIndex = 3;
            this.btnLb.Text = "ListBox";
            this.btnLb.UseVisualStyleBackColor = true;
            this.btnLb.Click += new System.EventHandler(this.btnLb_Click);
            // 
            // btnLv
            // 
            this.btnLv.Location = new System.Drawing.Point(282, 50);
            this.btnLv.Name = "btnLv";
            this.btnLv.Size = new System.Drawing.Size(90, 50);
            this.btnLv.TabIndex = 4;
            this.btnLv.Text = "ListView";
            this.btnLv.UseVisualStyleBackColor = true;
            this.btnLv.Click += new System.EventHandler(this.btnLv_Click);
            // 
            // btnDgv
            // 
            this.btnDgv.Location = new System.Drawing.Point(378, 50);
            this.btnDgv.Name = "btnDgv";
            this.btnDgv.Size = new System.Drawing.Size(90, 50);
            this.btnDgv.TabIndex = 5;
            this.btnDgv.Text = "DataGridView";
            this.btnDgv.UseVisualStyleBackColor = true;
            this.btnDgv.Click += new System.EventHandler(this.btnDgv_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDgv);
            this.Controls.Add(this.btnLv);
            this.Controls.Add(this.btnLb);
            this.Controls.Add(this.btnCmb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCmb;
        private System.Windows.Forms.Button btnLb;
        private System.Windows.Forms.Button btnLv;
        private System.Windows.Forms.Button btnDgv;
        private System.Windows.Forms.Button btnExit;
    }
}

