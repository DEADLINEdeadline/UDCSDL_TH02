using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    public class HinhTron
    {
        private int x;
        private int y;
        private double R;

        public HinhTron()
        {
            this.x = 0;
            this.y = 0;
            this.R = 0;
        }
        public HinhTron(int a, int b, double c)
        {
            this.x = a;
            this.y = b;
            this.R = c;
        }
        public HinhTron(HinhTron a)
        {
            this.x = a.x;
            this.y = a.y;
            this.R = a.R;
        }

        public void nhap()
        {
            Console.Write("x: ");
            this.x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            this.y = int.Parse(Console.ReadLine());
            Console.Write("Ban Kinh R: ");
            this.R = Double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Tam I = ({0},{1})", this.x, this.y);
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
            double a = Math.Sqrt(this.x * this.x+ this.y * this.y - this.R * this.R);
            if (this.R == a)
                Console.WriteLine("Duong Tron Hop Le");
            else
                Console.WriteLine("Duong Tron Ko Hop Le");
        }
    }
}
