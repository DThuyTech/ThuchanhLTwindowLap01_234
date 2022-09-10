using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0104
{
    internal class main
    {
        
        static void Main(string[] args)
        {
            List<khudat> lkd = new List<khudat>();
            lkd = nhapDSKdat();
            xuatDSkhudat(lkd);
            List<khudat> lkd2 = new List<khudat>(autoFill());
           
            foreach(khudat l in lkd2)
            {
                lkd.Add(l);
            }

            Console.WriteLine("danh sach co san va ban vua nhap la ");
            xuatDSkhudat(lkd);

            Console.WriteLine("Danh sach khu dat >100m2 hoac nha pho co dien tich 60ms va xay dung nam 2020");
            lkd100(lkd);

            //tim kiem
            Console.WriteLine("Tim kiem thong tin BDS");
            searchAS(lkd);
            
            Console.ReadKey();
           
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
                Console.WriteLine("Chon nhap Nha pho hoac Chung cu 1:2");
                check = int.Parse(Console.ReadLine());
                if (check == 1)
                {
                    nhapho np = new nhapho();
                    np.inputNP();
                    lst.Add(np);
                }
                else if (check == 2)
                {
                    chungcu cc = new chungcu();
                    cc.inputCC();
                    lst.Add(cc);
                }
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
        //xuast ds  khu dat co dien tich  > 100ms hoac nha pho ma  co dien tich > 60ms vaf xay dung nam 2020
        private static void lkd100(List<khudat> lkd)
        {
            List<khudat> lkd100b = lkd.Where(p => p.Dientich > 100.0f).ToList();
            List<khudat> lkdnp60 = lkd.Where(p => p is nhapho && (p as nhapho).Dientich > 60 && (p as nhapho).Dientich < 100 && (p as nhapho).Namxd >= 2020).ToList();
            //List<khudat> lkd100np60 = new List<khudat>();
            var lkd100np60 = lkd100b.Concat(lkdnp60).ToList();
            xuatDSkhudat(lkd100np60);
            Console.WriteLine("da chay");
        }

        private static double tonggiabanKhudat(List<khudat> lkd)
        {
            double tong = 0.0f;
            foreach (khudat kudat in lkd)
            {
                tong += kudat.Giaban;
            }
            return tong;
        }

        //tim theo dai chi,gia, dien tich
        private static void searchAS(List<khudat> lkd)
        {
            Console.WriteLine("\nNhap dia diem: ");
            string address = Console.ReadLine();
            Console.WriteLine("Nhap gia:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich:");
            double S = double.Parse(Console.ReadLine());
            List<khudat> lstAS = (from s in lkd
                                  where string.Equals(s.Diadiem, address, StringComparison.OrdinalIgnoreCase)
                                        && s.Giaban == price
                                        && s.Dientich == S
                                  select s
                                  ).ToList();
            if (lstAS.Count == 0)
            {
                Console.WriteLine("Khong thay");
            }
            else
                xuatDSkhudat(lstAS);
            
        }

        //tu dong dien
        private static List<khudat> autoFill()
        {
            List<khudat> ldk = new List<khudat>()
            {
                new khudat(){Diadiem="quan 9",Giaban= 1000000,Dientich = 500.0f},
                new khudat(){Diadiem="quan 1",Giaban= 50000000,Dientich = 30},
                new khudat(){Diadiem="thu duc",Giaban= 5000000,Dientich = 50},
                new nhapho(){Diadiem="quan 9",Giaban= 1000000,Dientich = 500,Namxd = 2020,Sotang = 2},
                new nhapho(){Diadiem="quan 7",Giaban= 10000000,Dientich = 70,Namxd = 2021,Sotang = 1},
                new nhapho(){Diadiem="quan 9",Giaban= 100000000,Dientich = 1000,Namxd = 2019,Sotang = 3},
                new chungcu(){Diadiem="thu duc",Giaban= 5500000,Dientich = 150,Tang =10},
                new chungcu(){Diadiem="linh trung",Giaban= 500000,Dientich = 110,Tang =2},

               


            };
            return ldk;
        }
    }
}
