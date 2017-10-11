using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay
{
    public class Ngay
    {
        private int ngay, thang, nam;

        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }
        public Ngay()
        {
            this.ngay = 1;
            this.thang = 1;
            this.nam = 1;
        }
        public Ngay(int d, int m, int y)
        {
            this.ngay = d;
            this.thang = m;
            this.nam = y;
        }
        public Ngay(Ngay a)
        {
            this.ngay = a.ngay;
            this.thang = a.thang;
            this.nam = a.nam;
        }

        public void nhap()
        {
            Console.Write("Ngay: ");
            this.ngay = int.Parse(Console.ReadLine());
            Console.Write("Thang: ");
            this.thang = int.Parse(Console.ReadLine());
            Console.Write("Nam: ");
            this.nam = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0}/{1}/{2}", this.ngay, this.thang, this.nam);
        }
        public void ktN()
        {
            if (this.thang == 1 || this.thang == 3 || this.thang == 5 || this.thang == 7 || this.thang == 8 || this.thang == 10 || this.thang == 12)
            {
                if (this.ngay >= 1 && this.ngay <= 31)
                    Console.WriteLine("Ngay Hop Le");
                else
                    Console.WriteLine("Ngay Ko Hop Le");
            }
            if (this.thang == 4 || this.thang == 6 || this.thang == 9 || this.thang == 11)
            {
                if (this.ngay >= 1 && this.ngay <= 30)
                    Console.WriteLine("Ngay Hop Le");
                else
                    Console.WriteLine("Ngay Ko Hop Le");
            }
            if (this.thang == 2)
            {
                if (ktNN() == true)
                {
                    if (this.ngay >= 1 && this.ngay <= 29)
                        Console.WriteLine("Ngay Hop Le");
                    else
                        Console.WriteLine("Ngay Ko Hop Le");
                }
                else
                {
                    if (this.ngay >= 1 && this.ngay <= 28)
                        Console.WriteLine("Ngay Hop Le");
                    else
                        Console.WriteLine("Ngay Ko Hop Le");
                }
            }
        }
        public bool ktNN()
        {
            if (this.nam % 4 == 0 && this.nam % 100 != 0 || this.nam % 400 == 0)
                return true;
            else
                return false;
        }
        public double kcGHN(Ngay A,Ngay B)
        {
            double kq = 0;
            if (A.nam != B.nam)
            {
                Ngay C = A;
                for (int i = A.nam; i < B.nam; i++)
                {
                    if (C.ktNN() == true)
                        kq += 366 * 24 * 60;
                    else
                        kq += 365 * 24 * 60;
                    C.nam++;
                }
            }
            if (A.thang != B.thang)
            {
                for (int i = A.thang; i < B.thang; i++)
                {
                    if (i== 1 || i == 3 || i == 5 || i== 7 || i == 8 || i == 10 || i == 12)
                        kq += 31 * 24 * 60;
                    if (i == 4 || i == 6 || i == 9 || i == 11)
                        kq += 30 * 24 * 60;
                    if (i == 2)
                    {
                        if (ktNN() == true)
                            kq += 29 * 24 * 60;
                        else
                            kq += 28 * 24 * 60;
                    }
                }
            }
            if (A.ngay != B.ngay)
            {
                for (int i = A.ngay; i < B.ngay; i++)
                {
                    kq += 24 * 60;
                }
            }
            return kq;
        }
    }
}