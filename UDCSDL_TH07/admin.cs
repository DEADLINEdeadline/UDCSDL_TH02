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
    public partial class frmAdmin : Form
    {
        BindingSource listAccount = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dgvAccount.DataSource = listAccount;
            addAccountBinding();
            LoadAccount();
        }

        void addAccountBinding()
        {
            txtUsername.DataBindings.Add("Text", dgvAccount.DataSource, "Tên Đăng Nhập", true, DataSourceUpdateMode.Never);
            txtDisplayName.DataBindings.Add("Text", dgvAccount.DataSource, "Họ Tên", true, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", dgvAccount.DataSource, "Email", true, DataSourceUpdateMode.Never);
        }
        
        public void LoadAccount()
        {
            listAccount.DataSource = AccountDAO.Instance.getListAccount();
        }

        void editAccount(string displayname, string type)
        {

        }


        private void btnViewNhanVien_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            frmRegister frmregister = new frmRegister();
            frmregister.ShowDialog();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnEditNhanVien_Click(object sender, EventArgs e)
        {
        }
    }
}
