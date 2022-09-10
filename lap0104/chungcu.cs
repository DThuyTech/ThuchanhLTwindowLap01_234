using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0104
{
    internal class chungcu : khudat
    {
        private int tang;

        public int Tang { get => tang; set => tang = value; }
        public chungcu() : base () { }
        public chungcu(string diadiem, double giaban, double dientich, int tang) : base (diadiem, giaban, dientich)
        {
            Tang = tang;
           
        }
        public chungcu (chungcu obj) : base(obj.Diadiem, obj.Giaban, obj.Dientich)
        {
            tang = obj.tang;
           
        }
        public void inputCC()
        {
            base.input();
            Console.WriteLine("Nhap tang: ");
            tang = int.Parse(Console.ReadLine());
           
        }
        public override void output()
        {
            Console.WriteLine("\nChung cu \nDia diem: {0}\nGia ban: {1}\nDien tich: {2}\nTang: {3}", base.Diadiem, base.Giaban, base.Dientich, Tang);
        }
    }
}
