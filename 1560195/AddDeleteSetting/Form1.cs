using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDeleteSetting
{
    public partial class Form1 : Form
    {
        DataTable dsKH;
        DataRow ds;
        DataView ttKH;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsKH = new DataTable();
            dsKH.Columns.Add("Ma");
            dsKH.Columns.Add("Ten");
            dsKH.Columns.Add("SDT");
            dsKH.Columns.Add("Tinh");

            ds = dsKH.NewRow();
            ds[0] = 1;
            ds[1] = "Nguyễn Đức Hoàng";
            ds[2] = "0123456789";
            ds[3] = "TP HCM";
            dsKH.Rows.Add(ds);

            ds = dsKH.NewRow();
            ds[0] = 2;
            ds[1] = "Lăng Lam";
            ds[2] = "0123456987";
            ds[3] = "Q10";
            dsKH.Rows.Add(ds);

            ds = dsKH.NewRow();
            ds[0] = 3;
            ds[1] = "Evans Ray Kyle";
            ds[2] = "0123654789";
            ds[3] = "P15";
            dsKH.Rows.Add(ds);

            ds = dsKH.NewRow();
            ds[0] = 4;
            ds[1] = "Yaclizk";
            ds[2] = "0321456789";
            ds[3] = "Bửu Long";
            dsKH.Rows.Add(ds);

            ds = dsKH.NewRow();
            ds[0] = 5;
            ds[1] = "Sacrificial Soul";
            ds[2] = "0987654321";
            ds[3] = "C2A";
            dsKH.Rows.Add(ds);

            DanhSachKhachHang.DataSource = dsKH;
            DanhSachKhachHang.ReadOnly = false;
        }

        private void find_TextChanged(object sender, EventArgs e)
        {
            ttKH = new DataView(dsKH);
            if (find.Text == "")
            {
                ttKH.RowFilter = "";
            }
            else
            {
                ttKH.RowFilter = "Ten like '%" + find.Text + "%'";
            }
            DanhSachKhachHang.DataSource = ttKH;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (id.Text != "" || name.Text != "" || sdt.Text != "" || tinh.Text != "")
            {
                for (int i = 0;i < DanhSachKhachHang.RowCount - 1;i++)
                {
                    ds = dsKH.Rows[i];
                    if (ds[0].ToString() == id.Text)
                    {
                        MessageBox.Show("Trùng Mã KH");
                        return;
                    }
                    else
                    {
                        ds = dsKH.NewRow();
                        ds[0] = id.Text;
                        ds[1] = name.Text;
                        ds[2] = sdt.Text;
                        ds[3] = tinh.Text;
                        dsKH.Rows.Add(ds);
                        return;
                    }
                }
            }
            
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            //for (int i = 0;i < DanhSachKhachHang.RowCount - 1;i++)
            //{
            //    ds = dsKH.Rows[i];
            //    if (ds[0].ToString() == id.Text)
            //        ds.Delete();
            //}
            int row = DanhSachKhachHang.CurrentCell.RowIndex;
            DanhSachKhachHang.Rows.RemoveAt(row);
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= DanhSachKhachHang.RowCount - 1; i++)
            {
                ds = dsKH.Rows[i];
                if (ds[0].ToString() == id.Text)
                {
                    ds = dsKH.Rows[i];
                    ds[0] = id.Text;
                    ds[1] = name.Text;
                    ds[2] = sdt.Text;
                    ds[3] = tinh.Text;
                    return;
                }
            }
        }

        private void DanhSachKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id.Text = this.DanhSachKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.name.Text = this.DanhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.sdt.Text = this.DanhSachKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.tinh.Text = this.DanhSachKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}