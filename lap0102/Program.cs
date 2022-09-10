using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lap0102;


namespace lap0102
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> lps = new List<person>();
            lps = nhapDSper();

            xuatDSstdent(lps);

            //xuat list sinh vien CNTT
            List<person> lstCNTT = lps.Where(p => p is student && (p as student).Faculty == "CNTT").ToList();
            xuatDSstdent(lstCNTT);


            //xuat list co diem TB nho hon 5 va CNTT
            List<person> lstCNTTbehon5 = lstCNTT.Where(p => p is student && (p as student).AverageSc < 5).ToList();
            xuatDSstdent(lstCNTTbehon5);

            //xuat list giao vien o quan 9
            List<person> ltcQ9 = lps.Where(p => p is teacher && (p as teacher).Diachi == "Quan 9").ToList();
            xuatDSstdent(ltcQ9);

            List<person> ltcms = lps.Where(p => p is teacher && (p as teacher).Maso == "CHN060286").ToList();
            if (ltcms.Count > 0)
            {
                xuatDSstdent(ltcms);
            }
            else
                Console.WriteLine("khong co ");



            Console.ReadKey();
        }
        private static List<person> nhapDSper()
        {
            Console.WriteLine("Nhap so doi tuong muon them: ");

            int N = int.Parse(Console.ReadLine());
            List<person> lst = new List<person>();

            int i = 0;
            int check;
            person ps;
            while(i < N)
            {
                Console.WriteLine("Chon nhap Student hoac Teacher 1:2");
                check = int.Parse(Console.ReadLine());
                if(check ==1)
                {
                    student st = new student();
                    st.intputST();
                    lst.Add(st);
                }
                else if (check == 2)
                {
                    teacher tc = new teacher();
                    tc.intputTC();
                    lst.Add(tc);
                }
                i++;
            }
            return lst;

        }
        private static void xuatDSstdent(List<person> lst)
        {
            foreach (person ite in lst)
            {
                ite.output();

            }
            Console.ReadKey();
        }

    }
}
