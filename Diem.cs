using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diem
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
        public Diem(int a,int b)
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
        public double khoangCach(Diem A)
        {
            double k, c, kc;
            k = Math.Pow(this.x - A.x, 2);
            c = Math.Pow(this.y - A.y, 2);
            kc = 1.0 * Math.Sqrt(k + c);
            return kc;
        }
        public void ktdtPT()
        {
            if (this.x > 0 && this.y > 0)
                Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 1", this.x, this.y);
            else
                if (this.x < 0 && this.y > 0)
                    Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 2", this.x, this.y);
                else
                    if (this.x < 0 && this.y < 0)
                        Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 3", this.x, this.y);
                    else
                        Console.WriteLine("Diem ({0},{1}) thuoc phan tu thu 4", this.x, this.y);   
        }
    }
}
