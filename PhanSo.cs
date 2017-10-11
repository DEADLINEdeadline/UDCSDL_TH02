using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    public class PhanSo
    {
        private double tu;
        private double mau;

        public PhanSo()
        {
            this.tu = 0;
            this.mau = 1;
        }
        public PhanSo(double a,double b)
        {
            this.tu = a;
            this.mau = b;
        }
        public PhanSo(PhanSo a)
        {
            this.tu = a.tu;
            this.mau = a.mau;
        }

        public void nhap()
        {
            Console.Write("tu = ");
            this.tu = Double.Parse(Console.ReadLine());
            Console.Write("mau = ");
            this.mau = Double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("PS = {0}/{1}", this.tu, this.mau);
        }
        public double tinhGiaTri()
        {
            return 1.0 * this.tu / this.mau;
        }
        public bool ktPSHL()
        {
            if (this.mau == 0)
                return false;
            else
                return true;
        }
        public double UCLL(double a,double b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public PhanSo rutgonPS()
        {
            PhanSo a = new PhanSo();
            a.tu = this.tu / UCLL(this.tu, this.mau);
            a.mau = this.mau / UCLL(this.tu, this.mau);
            return a;
        }
        public PhanSo Tong(PhanSo n)
        {
            PhanSo a = new PhanSo();
            if (this.mau == n.mau)
            {
                a.tu = this.tu + n.tu;
                a.mau = this.mau;
            }
            else
            {
                a.tu = this.tu * n.mau + this.mau * n.tu;
                a.mau = this.mau * n.mau;
            }
            return a;
        }
        public PhanSo Hieu(PhanSo n)
        {
            PhanSo a = new PhanSo();
            if (this.mau == n.mau)
            {
                a.tu = this.tu - n.tu;
                a.mau = this.mau;
            }
            else
            {
                a.tu = this.tu * n.mau - this.mau * n.tu;
                a.mau = this.mau * n.mau;
            }
            return a;
        }
        public PhanSo Tich(PhanSo n)
        {
            PhanSo a = new PhanSo();
            a.tu = this.tu * n.tu;
            a.mau = this.mau * n.mau;
            return a;
        }
    }
}
