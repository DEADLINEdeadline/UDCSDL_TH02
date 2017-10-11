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

        public NhanVien()
        {

        }
        public NhanVien(string hoten,Ngay namsinh,int chungminh,string diachi,string bangcap) : base(hoten, namsinh, chungminh, diachi)
        {
            this.bangcap = bangcap;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Bang cap: ");
            this.bangcap = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Bang cap: {0}", this.bangcap);
            Console.WriteLine("Tuoi: {0}", tuoi());
        }
        public override float tuoi()
        {
            return base.tuoi();
        }
    }
}
