using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class Sach
    {
        private int maS;
        private string tenS;
        private double giaS;

        public Sach()
        {
            this.maS = 1;
            this.tenS = "Khoa Hoc Vu Tru";
            this.giaS = 50000;
        }
        public Sach(int ma,string ten,int gia)
        {
            this.maS = ma;
            this.tenS = ten;
            this.giaS = gia;
        }
        public Sach(Sach A)
        {
            this.maS = A.maS;
            this.tenS = A.tenS;
            this.giaS = A.giaS;
        }

        public virtual void nhap()
        {
            Console.Write("Ma Sach: ");
            this.maS = int.Parse(Console.ReadLine());
            Console.Write("Ten Sach: ");
            this.tenS = Console.ReadLine();
            Console.Write("Gia Sach: ");
            this.giaS = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma Sach: {0}", this.maS);
            Console.WriteLine("Ten Sach: {0}", this.tenS);
            Console.WriteLine("Gia Sach: {0}", this.giaS);
        }
    }
}
