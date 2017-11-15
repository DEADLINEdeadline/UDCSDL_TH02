using Login.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text, passWord = txtPassword.Text;

            if (Login(userName, passWord))
            {
                frmAdmin admin = new frmAdmin();
                this.Hide();
                admin.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát.", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            frmConfirmEmail findPassword = new frmConfirmEmail();
            findPassword.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmregister = new frmRegister();
            frmregister.ShowDialog();
        }
    }
}
