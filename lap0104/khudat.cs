using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0104
{
    internal class khudat
    {
        private string diadiem;
        private double giaban;
        private double dientich;

        public khudat(string diadiem, double giaban, double dientich)
        {
            this.diadiem = diadiem;
            this.giaban = giaban;
            this.dientich = dientich;
        }
        public khudat() { }
        public khudat(khudat obj)
        {
            diadiem = obj.diadiem;
            giaban = obj.Giaban;
            dientich = obj.dientich;    
        }

        public string Diadiem { get => diadiem; set => diadiem = value; }
        public double Giaban { get => giaban; set => giaban = value; }
        public double Dientich { get => dientich; set => dientich = value; }

        public void input()
        {
            Console.WriteLine("Nhap dia diem:  ");
            diadiem = Console.ReadLine();
            Console.WriteLine("Nhap gia ban:  ");
            giaban = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich:  ");
            dientich = double.Parse(Console.ReadLine());
        }
        public virtual void output()
        {
            Console.WriteLine("\nKhu dat \nDia diem: {0}\nGia ban: {1}\nDien tich: {2}\n", diadiem, giaban, dientich);
        }
    }
}
