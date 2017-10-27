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
    public partial class frmDgv : Form
    {
        public frmDgv()
        {
            InitializeComponent();
        }

        private void btnCmbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Datagridview_Load(object sender, EventArgs e)
        {
            string sql = "select tenMonHoc from MONHOC";
            DataTable dt = DataProvider.LoadCSDL(sql);

            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.AllowUserToDeleteRows = false;
            dgvMonHoc.RowHeadersVisible = false;
            
            dgvMonHoc.DataSource = dt;
        }
    }
}
