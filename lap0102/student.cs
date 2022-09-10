using lap0102;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0102
{
    public class student :person

    {
        private float averageSc;
        private string faculty;      
        public float AverageSc
        {
            get { return averageSc; }
            set { averageSc = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public student() { }
        
        public student(string fullname,string stdID,float aver,string facu) : base(fullname,stdID)
        {
           
           
            AverageSc = aver;
            Faculty = facu;
        }
        public student(student obj) : base(obj.Fullname,obj.Maso)
        {
           
            AverageSc = obj.averageSc;
            Faculty = obj.faculty;
        }
        public void intputST()
        {
            base.inputPer();
            Console.Write("Nhap diem TB: ");
            averageSc =float.Parse(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            faculty = Console.ReadLine();
        }
        public override void output()
        {
            Console.WriteLine("da chay");
            Console.WriteLine("MSSV: {0} \n,Ho ten: {1}\nDiem: {2}\nKhoa: {3}", base.Maso, base.Fullname, this.averageSc, this.faculty);
        }
    }
}
