using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguoi
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
        public Ngay(int d,int m,int y)
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
    }
}
