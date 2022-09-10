using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0102
{
    public class teacher:person
    {
        private string diachi;

        public teacher():base() { }
        public teacher(string fullname, string maso, string diachi) : base(fullname,maso)
        {
            this.diachi = diachi;
        }
        public teacher(teacher obj): base (obj.Fullname,obj.Maso) {
            this.diachi = obj.diachi;
        }


        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }
        public void intputTC()
        {
            base.inputPer();
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
        }
        public override void output()
        {
           
            Console.WriteLine("MSSV: {0} \n,Ho ten: {1}\nDia chi: {2}", base.Maso, base.Fullname, this.diachi);
        }
    }
}
