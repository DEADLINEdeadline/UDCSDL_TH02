using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fmQuanLyKhachHang : Form
    {
        public fmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        DataTable dtQuanLyKhachHang;
        DataView dvQuanLyKhachHang;

        private void fmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            string str = "";
            
            string[] loiChuc = { "Hạnh Phúc", "Ấm Áp", "Mát Mẻ", "Đẹp Đẽ", "No Đầy",
                "Mệt Mỏi", "Buồn Bã", "Chán Đời", "Vui Tươi", "Chán Nản" };
            Random rd = new Random();
            int numRd = rd.Next(0, loiChuc.Count() - 1);
            
            int time = DateTime.Now.Hour;
            if(time > 0 && time <= 10)
            {
                str = " Buổi Sáng " + loiChuc[numRd] ;
            }
            else if(time > 10 && time <= 15)
            {
                str = " Buổi Trưa " + loiChuc[numRd];
            }
            else if(time > 15 && time <= 18)
            {
                str = " Buổi Chiều " + loiChuc[numRd];
            }
            else
            {
                str = " Buổi Tối " + loiChuc[numRd];
            }

            lbHello.Text = lbHello.Text + str;

            timer1.Start();//đồng hồ
            dtQuanLyKhachHang = new DataTable();
            dtQuanLyKhachHang.Columns.Add("ID");
            dtQuanLyKhachHang.Columns.Add("Name");
            dtQuanLyKhachHang.Columns.Add("Country");
            dtQuanLyKhachHang.Columns.Add("Phone");

            DataRow kh = dtQuanLyKhachHang.NewRow();

            kh["ID"] = 1;
            kh["Name"] = "Trần văn A";
            kh["Country"] = "Sài Gòn";
            kh["Phone"] = "0909090909";

            dtQuanLyKhachHang.Rows.Add(kh);

            kh = dtQuanLyKhachHang.NewRow();

            kh["ID"] = 2;
            kh["Name"] = "TRẦN TRUNG";
            kh["Country"] = "Tiền Giang";
            kh["Phone"] = "0909999999";

            dtQuanLyKhachHang.Rows.Add(kh);

            kh = dtQuanLyKhachHang.NewRow();

            kh["ID"] = 3;
            kh["Name"] = "KIÊN Trung";
            kh["Country"] = "Mỹ Tho";
            kh["Phone"] = "0909888888";

            dtQuanLyKhachHang.Rows.Add(kh);

            kh = dtQuanLyKhachHang.NewRow();

            kh["ID"] = 4;
            kh["Name"] = "Sỹ Hoàng";
            kh["Country"] = "Sài Gòn";
            kh["Phone"] = "0909777777";

            dtQuanLyKhachHang.Rows.Add(kh);

            kh = dtQuanLyKhachHang.NewRow();

            kh["ID"] = 5;
            kh["Name"] = "Barrack Obama";
            kh["Country"] = "USA";
            kh["Phone"] = "0909666666";

            dtQuanLyKhachHang.Rows.Add(kh);

            dgvListKhachHang.DataSource = dtQuanLyKhachHang;
            dgvListKhachHang.ReadOnly = true;


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dvQuanLyKhachHang = new DataView(dtQuanLyKhachHang);
            if (tbSearch.Text == "")
            {
                dvQuanLyKhachHang.RowFilter = "";
            }
            else
            {
                dvQuanLyKhachHang.RowFilter = "Name like '%" + tbSearch.Text + "%'";
            }

            dgvListKhachHang.DataSource = dvQuanLyKhachHang;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow kh = dtQuanLyKhachHang.NewRow();
            if (tbID.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khách Hàng");
                tbID.Focus();
            }
            else if (tbName.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Khách Hàng");
                tbName.Focus();
            }
            else if (tbCountry.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Quê Quán Khách Hàng");
                tbCountry.Focus();
            }
            else if (tbPhone.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại Khách Hàng");
                tbPhone.Focus();
            }
            else
            {
                for (int i = 0; i < dtQuanLyKhachHang.Rows.Count; i++)
                {
                    if (dtQuanLyKhachHang.Rows[i][0].ToString() == tbID.Text)
                    {
                        MessageBox.Show("Mã Khách Hàng bị Trùng");
                        return;
                    }
                    else
                    {
                        kh["ID"] = tbID.Text;
                        kh["Name"] = tbName.Text;
                        kh["Country"] = tbCountry.Text;
                        kh["Phone"] = tbPhone.Text;
                    }
                }
            }

            dtQuanLyKhachHang.Rows.Add(kh);
            //dgvListKhachHang.DataSource = dtQuanLyKhachHang;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dtQuanLyKhachHang.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dtQuanLyKhachHang.Rows[i];

                if (dr["ID"].ToString() == tbID.Text)
                {
                    dr.Delete();
                }

            }
        }
        

        private void dgvListKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //đổ dữ liệu từ datagridview vào textbox
            if (dgvListKhachHang.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Id = dgvListKhachHang.SelectedRows[0].Cells[0].Value + string.Empty;
                string Name = dgvListKhachHang.SelectedRows[0].Cells[1].Value + string.Empty;
                string Country = dgvListKhachHang.SelectedRows[0].Cells[2].Value + string.Empty;
                string Phone = dgvListKhachHang.SelectedRows[0].Cells[3].Value + string.Empty;

                tbID.Text = Id;
                //tbID.ReadOnly = true;

                tbName.Text = Name;
                //tbName.ReadOnly = true;

                tbCountry.Text = Country;
                //tbCountry.ReadOnly = true;

                tbPhone.Text = Phone;
                //tbPhone.ReadOnly = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;

            lbClock.Text = DateTime.UtcNow.ToLocalTime().ToString("HH:mm:ss" + " tt" + " dd/MM/yyyy");
        }
    }
}
