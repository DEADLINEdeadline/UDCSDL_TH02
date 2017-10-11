using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien_Nguoi
{
    public class NhanVien : Nguoi
    {
        private string bangcap;
        private int n;
        private Nguoi[] A = new Nguoi[100];
        public NhanVien()
        {
            //Nguoi B = new Nguoi();
            //this.bangcap = "Gioi";
        }
        public NhanVien(string hoten,Ngay namsinh,int chungminh,string diachi,string bangcap) : base(hoten, namsinh, chungminh, diachi)
        {
            this.bangcap = bangcap;
        }
        public override void nhap()
        {
            Console.Write("n = ");
            this.n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                A[i] = new Nguoi();
                A[i].nhap();
                Console.Write("Bang cap: ");
                this.bangcap = Console.ReadLine();
            }   
        }
        public override void xuat()
        {
            for (int i = 0; i < n; i++)
            {
                A[i].xuat();
                Console.WriteLine("Bang cap: {0}", this.bangcap);
                Console.WriteLine("Tuoi: {0}", tuoi());
            }  
        }
        public override float tuoi()
        {
            return base.tuoi();
        }
    }
}
