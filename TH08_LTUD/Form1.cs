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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCmb_Click(object sender, EventArgs e)
        {
            frmCmb cmb = new frmCmb();
            cmb.ShowDialog();
        }

        private void btnLb_Click(object sender, EventArgs e)
        {
            frmLb lb = new frmLb();
            lb.ShowDialog();
        }

        private void btnLv_Click(object sender, EventArgs e)
        {
            frmLv lv = new frmLv();
            lv.ShowDialog();
        }

        private void btnDgv_Click(object sender, EventArgs e)
        {
            frmDgv dgv = new frmDgv();
            dgv.ShowDialog();
        }
    }
}
