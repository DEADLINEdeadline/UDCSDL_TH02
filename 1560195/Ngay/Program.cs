using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay
{
    class Program
    {
        static void Main(string[] args)
        {
            Ngay a = new Ngay();
            a.nhap();
            a.xuat();
            a.ktN();
            if (a.ktNN() == true)
                Console.WriteLine("Nam Nhuan");
            else
                Console.WriteLine("Ko Phai Nam Nhuan");
            Ngay b = new Ngay();
            b.nhap();
            Ngay c = new Ngay();
            c.nhap();
            Console.WriteLine("Khoang cach giua 2 ngay: {0}", a.kcGHN(b, c));
        }
    }
}
