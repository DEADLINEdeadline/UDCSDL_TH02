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
    public partial class frmNewPassword : Form
    {
        public frmNewPassword()
        {
            InitializeComponent();
        }
        public static string Email = string.Empty;

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            string Password = txtNewPass.Text;
            string reNewPassword = txtReNewPass.Text;
            
            //MessageBox.Show(Email);
            if(Password != reNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không giống nhau");
            }
            else if( changePassword(Password, Email) )
            {
                MessageBox.Show("Thay đổi mật khẩu thành công");
                this.Hide();
            }
        }
        bool changePassword(string Password, string email)
        {
            return AccountDAO.Instance.changePassword(Password, email);
        }
    }
}
