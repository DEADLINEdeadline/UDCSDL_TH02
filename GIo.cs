using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gio
{
    public class Gio
    {
        private int h;
        public int H
        {
            get { return h; }
            set { h = value; }
        }

        private int p;
        private int s;

        public Gio()
        {
            this.h = 0;
            this.p = 0;
            this.s = 0;
        }
        public Gio(int gio,int phut,int giay)
        {
            this.h = gio;
            this.p = phut;
            this.s = giay;
        }
        public Gio(Gio A)
        {
            this.h = A.h;
            this.p = A.p;
            this.s = A.s;
        }

        public void nhap()
        {
            Console.Write("Gio: ");
            this.h = int.Parse(Console.ReadLine());
            Console.Write("Phut: ");
            this.p = int.Parse(Console.ReadLine());
            Console.Write("Giay: ");
            this.s = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0}:{1}:{2}", this.h, this.p, this.s);
        }
        public bool ktHL()
        {
            if (this.h >= 0 && this.h <= 23)
            {
                if (this.p >= 0 && this.p <= 60)
                {
                    if (this.s >= 0 && this.s <= 60)
                        return true;
                    else
                        return false;
                }
                return false;
            }
            else
                return false;
            
        }
        public void sdoiSGP(int A)
        {
            int G, P, B, C;
            G = A / (60 * 60);
            P = A % (60 * 60);
            B = P / 60;
            C = A % 60;
            Console.WriteLine("{0} Giay = {1} Gio {2} Phut {3} Giay", A, G, B, C);
        }
        public double kcGHG(Gio A,Gio B)
        {
            double kq = 0; ;
            for (int i = A.h; i < B.h;i++)
            {
                kq += 60;
            }
            return kq;
        }
    }
}
