namespace Login
{
    partial class frmConfirmEmail
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
            this.txtXacNhanMail = new System.Windows.Forms.TextBox();
            this.btnXacNhanMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chúng tôi sẽ gửi đến Email";
            // 
            // txtXacNhanMail
            // 
            this.txtXacNhanMail.Location = new System.Drawing.Point(187, 32);
            this.txtXacNhanMail.Name = "txtXacNhanMail";
            this.txtXacNhanMail.Size = new System.Drawing.Size(192, 20);
            this.txtXacNhanMail.TabIndex = 1;
            this.txtXacNhanMail.Text = "1560194@gmail.com";
            // 
            // btnXacNhanMail
            // 
            this.btnXacNhanMail.Location = new System.Drawing.Point(304, 74);
            this.btnXacNhanMail.Name = "btnXacNhanMail";
            this.btnXacNhanMail.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhanMail.TabIndex = 2;
            this.btnXacNhanMail.Text = "OK";
            this.btnXacNhanMail.UseVisualStyleBackColor = true;
            this.btnXacNhanMail.Click += new System.EventHandler(this.btnXacNhanMail_Click);
            // 
            // frmConfirmEmail
            // 
            this.AcceptButton = this.btnXacNhanMail;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 111);
            this.Controls.Add(this.btnXacNhanMail);
            this.Controls.Add(this.txtXacNhanMail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfirmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXacNhanMail;
        private System.Windows.Forms.Button btnXacNhanMail;
    }
}