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
    public partial class frmLb : Form
    {
        public frmLb()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            string sql = "select * from MONHOC";
            DataTable dt = DataProvider.LoadCSDL(sql);

            lbMonHoc.DataSource = dt;
            lbMonHoc.DisplayMember = "TenMon";
            lbMonHoc.ValueMember = "tenMonHoc";
        }

        private void btnCmbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
