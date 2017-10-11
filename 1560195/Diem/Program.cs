using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diem
{
    class Program
    {
        static void Main(string[] args)
        {
            Diem a = new Diem();
            Diem b = new Diem(1, 1);
            Diem c = new Diem(b);
            a.xuat();
            b.xuat();
            c.xuat();
            a.nhap();
            a.xuat();

            Console.WriteLine("d(a,b) = {0}", a.khoangCach(b));
            a.ktdtPT();
        }
    }
}
