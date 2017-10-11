using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            ChuNhat A = new ChuNhat();
            A.nhap();
            A.xuat();
            Console.WriteLine("Chu vi: {0}", A.chuvi());
            Console.WriteLine("Dien tich: {0}", A.dientich());
            A.ktHCN();
        }
    }
}
