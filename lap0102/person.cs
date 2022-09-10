using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0102
{
     public class person
    {
        private string fullname;
        private string maso;

        public person(string fullname, string maso)
        {
            this.fullname = fullname;
            this.maso = maso;
        }

        public person()
        {
           
        }
        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
            }
        }

        public string Maso
        {
            get
            {
                return maso;
            }

            set
            {
                maso = value;
            }

        }
        
        public void inputPer()
        {
            Console.Write("Nhap MS: ");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            fullname = Console.ReadLine();
        }
        public virtual void output() { }
    }
}
