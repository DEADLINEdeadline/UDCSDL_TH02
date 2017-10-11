using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron_Diem
{
    public class HinhTron
    {
        private Diem i;
        private double R;

        public HinhTron()
        {
            this.i = new Diem();
            this.R = 0;
        }
        public HinhTron(Diem a, double c)
        {
            this.i = new Diem(a);
            this.R = c;
        }
        public HinhTron(HinhTron a)
        {
            this.i = a.i;
            this.R = a.R;
        }

        public void nhap()
        {
            Console.WriteLine("Tam I: ");
            this.i.nhap();
            Console.Write("Ban Kinh R: ");
            this.R = Double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("Tam I = ");
            this.i.xuat();
            Console.WriteLine("BK R = {0}", this.R);
        }
        public double dientich()
        {
            double S;
            S = Math.Pow(this.R, 2) * 3.14;
            return S;
        }
        public double chuvi()
        {
            double S;
            S = this.R * 2 * 3.14;
            return S;
        }
        public void ktHL()
        {
            double a = Math.Sqrt(this.i.X * this.i.X + this.i.Y * this.i.Y - this.R * this.R);
            if (this.R == a)
                Console.WriteLine("Duong Tron Hop Le");
            else
                Console.WriteLine("Duong Tron Ko Hop Le");
        }
    }
}
