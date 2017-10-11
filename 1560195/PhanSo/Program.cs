using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo(1, 2);
            PhanSo c = new PhanSo(b);
            a.xuat();
            b.xuat();
            c.xuat();
            a.nhap();
            a.xuat();

            if (a.ktPSHL() == true)
                Console.WriteLine("Phan So Hop Le");
            else
                Console.WriteLine("Phan So Ko Hop Le");

            Console.Write("PS rut gon: ");
            PhanSo d = a.rutgonPS();
            d.xuat();

            Console.Write("Tong: ");
            PhanSo e = a.Tong(c);
            e.xuat();
            Console.Write("Hieu: ");
            PhanSo f = a.Hieu(b);
            f.xuat();
            Console.Write("Tich: ");
            PhanSo g = a.Tich(b);
            g.xuat();
        }
    }
}
