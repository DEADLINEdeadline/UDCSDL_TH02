using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron_Diem
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron A = new HinhTron();
            Diem i = new Diem(1, 2);
            HinhTron B = new HinhTron(i, 3);
            HinhTron C = new HinhTron(B);
            A.xuat();
            B.xuat();
            C.xuat();
            A.nhap();
            A.xuat();
            Console.WriteLine("Dien tich = {0}", A.dientich());
            Console.WriteLine("Chu vi = {0}", A.chuvi());
            A.ktHL();
        }
    }
}
