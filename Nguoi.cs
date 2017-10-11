using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguoi
{
    public class Nguoi
    {
        private string ht;
        private Ngay ns;
        private int cmnd;
        private string dc;

        public Nguoi()
        {
            this.ht = "Nguyen Duc Hoang";
            this.ns = new Ngay();
            this.cmnd = 123456789;
            this.dc = "C2A Buu Long,P 15,Q 10,TP HCM";
        }
        public Nguoi(string h,Ngay n,int cm,string d)
        {
            this.ht = h;
            this.ns = n;
            this.cmnd = cm;
            this.dc = d;
        }
        public Nguoi(Nguoi a)
        {
            this.ht = a.ht;
            this.ns = a.ns;
            this.cmnd = a.cmnd;
            this.dc = a.dc;
        }

        public void nhap()
        {
            Console.Write("Ho Ten: ");
            this.ht = Console.ReadLine();
            Console.WriteLine("Ngay Sinh: ");
            this.ns.nhap();
            Console.Write("CMND: ");
            this.cmnd = int.Parse(Console.ReadLine());
            Console.Write("Dia Chi: ");
            this.dc = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("Ho Ten: {0}", this.ht);
            Console.Write("Ngay Sinh: ");
            this.ns.xuat();
            Console.WriteLine("CMND: {0}", this.cmnd);
            Console.WriteLine("Dia Chi: {0}", this.dc);
        }
        public float tuoi()
        {
            float t;
            t = DateTime.Now.Year - this.ns.Nam;
            return t;
        }
    }
}
