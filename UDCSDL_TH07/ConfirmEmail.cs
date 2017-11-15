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
    public partial class frmConfirmEmail : Form
    {
        public frmConfirmEmail()
        {
            InitializeComponent();
        }
        private void btnXacNhanMail_Click(object sender, EventArgs e)
        {

            string email = txtXacNhanMail.Text;

            if (confirmEmail(email))
            {
                frmNewPassword.Email = txtXacNhanMail.Text;

                frmNewPassword newPassword = new frmNewPassword();

                newPassword.ShowDialog();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai địa chỉ email");
            }
        }

        bool confirmEmail(string userName)
        {
            return AccountDAO.Instance.confirmEmail(userName);
        }

    }
}
