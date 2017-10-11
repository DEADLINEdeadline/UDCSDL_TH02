using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gio
{
    class Program
    {
        static void Main(string[] args)
        {
            Gio A = new Gio();
            A.nhap();
            A.xuat();
            if (A.ktHL() == true)
                Console.WriteLine("Gio Hop Le");
            else
                Console.WriteLine("Gio Ko Hop Le");
            Console.Write("Nhap so giay: ");
            int s = int.Parse(Console.ReadLine());
            A.sdoiSGP(s);
            Gio B = new Gio(3, 0, 0);
            Gio C = new Gio(5, 0, 0);
            Console.WriteLine("Khoang cach giua {0} gio va {1} gio: {2}", B.H, C.H, A.kcGHG(B, C));
        }
    }
}
