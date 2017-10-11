using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron_Diem
{
    public class Diem
    {
        private int x;
        private int y;

        public Diem()
        {
            this.x = 0;
            this.y = 0;
        }
        public Diem(int a, int b)
        {
            this.x = a;
            this.y = b;
        }
        public Diem(Diem a)
        {
            this.x = a.x;
            this.y = a.y;
        }

        public void nhap()
        {
            Console.Write("x = ");
            this.x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            this.y = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
    }
}
