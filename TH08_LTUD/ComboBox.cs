using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocDuLieuDB
{
    public partial class frmCmb : Form
    {
        public frmCmb()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            string sql = "select * from MONHOC";
            DataTable dt = DataProvider.LoadCSDL(sql);

            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "TenMon";
            cmbMonHoc.ValueMember = "tenMonHoc";
        }

        private void btnCmbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
