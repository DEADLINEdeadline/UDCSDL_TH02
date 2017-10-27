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
    public partial class frmLv : Form
    {
        public frmLv()
        {
            InitializeComponent();
        }

        private void btnCmbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmLv_Load(object sender, EventArgs e)
        {
            string sql = "select * from MONHOC";
            DataTable dt = DataProvider.LoadCSDL(sql);
            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr[1].ToString());

                //listitem.SubItems.Add(dr[0].ToString());
                lvMonHoc.Items.Add(listitem);
            }
        }
    }
}
