using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0103
{
    internal class main
    {
        
        static void Main(string[] args)
        {
            List<khudat> lkd = new List<khudat>();
            //lkd = nhapDSKdat();
            Console.WriteLine("danh sach co san va ban vua nhap la ");
            List<khudat> lkd2 = new List<khudat>(autoFill());
            
            foreach (khudat l in lkd2)
            {
                lkd.Add(l);
            }
            xuatDSkhudat(lkd);
            Console.WriteLine("Sap xeop theo dien tich tang dan");
            lkd.Sort();
            xuatDSkhudat(lkd);

            //TB 1m2 cua nha gtren 1000m2
            if (TBlkd1m2S1000(lkd) > 0)
            {
                Console.WriteLine("Trung binh gia 1m2 cua nha cos dien tich tren 1000m2 la {0}", TBlkd1m2S1000(lkd));
            }
            else
                Console.WriteLine("khong co nha nao tren 1000ms");
        }
        private static List<khudat> nhapDSKdat()
        {
            Console.WriteLine("Nhap so doi tuong muon them: ");

            int N = int.Parse(Console.ReadLine());
            List<khudat> lst = new List<khudat>();

            int i = 0;
            int check;
            khudat kd;
            while (i < N)
            {
                Console.WriteLine("Chon nhap khu dat {0}",i+1);
                
                kd = new khudat();
                kd.input();
                lst.Add(kd);

                
                i++;
            }
            return lst;

        }
        private static void xuatDSkhudat(List<khudat> lst)
        {
            foreach (khudat ite in lst)
            {
                ite.output();

            }
            Console.ReadKey();
        }
        
        private static List<khudat> autoFill()
        {
            List<khudat> ldk = new List<khudat>()
            {
                new khudat(){Diadiem="quan 9",Giaban= 1000000,Dientich = 500},
                new khudat(){Diadiem="quan 1",Giaban= 50000000,Dientich = 30},
                new khudat(){Diadiem="thu duc",Giaban= 5000000,Dientich = 50},
                new khudat(){Diadiem="quan 1",Giaban= 5000000000,Dientich = 2000},
                new khudat(){Diadiem="vung tau",Giaban= 15000000000,Dientich = 4000},




            };
            return ldk;
        }
        private static void lkdbehon1bShon60(List<khudat> lkd)
        {
            List<khudat> lkd1B60M2 = lkd.Where(p => p.Dientich > 60 && p.Giaban <1000000000).ToList();
            xuatDSkhudat(lkd1B60M2);
            Console.WriteLine("da chay");
        }
        private static double TBlkd1m2S1000(List<khudat> lkd)
        {
            double tongS = 0.0f;
            double m2 = 0.0f;
            List<khudat> lkdnew = lkd.Where(p => p.Dientich > 1000 ).ToList();
            Console.WriteLine("danh sach nha tren 1000m2");
            if(lkdnew.Count > 0)
            {
                xuatDSkhudat(lkdnew);
                foreach (khudat l in lkdnew)
                {
                    tongS += l.Giaban / (double)l.Dientich;
                }
                double TBtongM2 = tongS / (double)lkdnew.Count();
                return TBtongM2;
            }
            return 0.0f;
        }
    }
}
