using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class ThuVien : Sach
    {
        private string loaiS;
        private Sach[] A = new Sach[100];
        private int n;

        public ThuVien()
        {
            Sach A = new Sach();
            this.loaiS = "Hoi Dap";
        }
        public ThuVien(int maS,string tenS,int giaS,string loaiS) : base(maS, tenS, giaS)
        {
            this.loaiS = loaiS;
        }

        public override void nhap()
        {
            Console.Write("n = ");
            this.n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n;i++)
            {
                A[i] = new Sach();
                A[i].nhap();
                Console.WriteLine("Loai Sach: ");
                this.loaiS = Console.ReadLine();
            }
        }
        public override void xuat()
        {
            for (int i = 0; i < n; i++)
            {
                A[i].xuat();
                Console.WriteLine("Loai Sach: {0}", this.loaiS);
            }
        }
    }
}
