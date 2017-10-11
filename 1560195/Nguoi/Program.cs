using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Nguoi A = new Nguoi();
            A.nhap();
            A.xuat();
            Console.WriteLine("Tuoi = {0}", A.tuoi());
        }
    }
}
