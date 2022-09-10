using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0104
{
    internal class nhapho : khudat
    {
        private int namxd;
        private int sotang;

        public nhapho(string diadiem, double giaban,double dientich,int namxd, int sotang) : base (diadiem,giaban,dientich)
        {
            this.namxd = namxd;
            this.sotang = sotang;
        }
        public nhapho() : base() { }

        public nhapho(nhapho obj ) : base(obj.Diadiem, obj.Giaban, obj.Dientich)
        {
            namxd = obj.Namxd;
            sotang = obj.Sotang;    
        }


        public int Namxd { get => namxd; set => namxd = value; }
        public int Sotang { get => sotang; set => sotang = value; }

        public void inputNP()
        {
            base.input();
            Console.WriteLine("Nhap nam xay dung: ");
            namxd = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tang: ");
            sotang = int.Parse(Console.ReadLine());
        }
        public override void  output()
        {
            Console.WriteLine("\nNha pho \nDia diem: {0}\nGia ban: {1}\nDien tich: {2}\nNam xay dung: {3}\nSo tang: {4}\n", base.Diadiem, base.Giaban, base.Dientich, namxd, sotang);
        }
        

       
    }
}
