using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom
{
    public partial class Form2 : Form
    {
        public string dong;
        public string cot;
        public Form2(string d,string c)
        {
            InitializeComponent();
            dong = d;
            cot = c;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int d = 1;
            if (!int.TryParse(dong,out d))
            {
                d = 1;
            }
            if (d < 0)
            {
                d = -d;
            }
            int c = 1;
            if (!int.TryParse(cot, out c))
            {
                c = 1;
            }
            if (d < 0)
            {
                c = -d;
            }
            int m = 0;
            for (int i = 0;i < d;i++)
            {
                for (int j = 0;j < c;j++)
                {
                    Button N = new Button();
                    N.Width = 35;
                    N.Height = 35;
                    N.Top = 40 * i;
                    N.Left = 40 * j;
                    N.Name = i.ToString() + "," + j.ToString();
                    N.Text = m.ToString();
                    N.Tag = string.Format("{0},{1}", i + 1, j + 1);
                    m++;
                    this.Controls.Add(N);
                    N.Click += new EventHandler(N_Click);
                }
            }
        }
        private void N_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+ ((Button)sender).Tag);
        }
    }
}
