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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text, passWord = txtPassword.Text, email = txtEmail.Text, displayname = txtDisplayName.Text;
            string typeAcc;
            if (rdbAdmin.Checked)
            {
                typeAcc = "1";
            }
            else
            {
                typeAcc = "0";
            }
            
            if (register(userName, displayname, email, passWord,typeAcc))
            {

                MessageBox.Show("Đăng ký thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("username hoặc email bị trùng");
            }
        }

        bool register(string username, String displayname,string email, string password, string typeacc)
        {
            return AccountDAO.Instance.register(username, displayname,email, password, typeacc);
        }
    }
}
