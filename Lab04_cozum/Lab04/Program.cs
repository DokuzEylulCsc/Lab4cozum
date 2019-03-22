using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab04
{
    class Program
    {
        private static ArrayList masukiye;
        static void Main(string[] args)
        {
            masukiye = new ArrayList();
            masukiye.Add(new Koylu("Ahmet"));
            masukiye.Add(new Koylu("Mehmet"));
            masukiye.Add(new Hayvan());
            masukiye.Add(new Hayvan());
            masukiye.Add(new Canli());
            masukiye.Add(new Canli());
            masukiye.Add(new Savasci("Erol",new Silah(20)));
            masukiye.Add(new Savasci("Varol", new Silah(30)));
            masukiye.Add(new Savasci("Birol", new Silah(40)));

            KoyluleriListele();
            SavascilariListele();
            Duelo();

            //Main verilir metot içelerinin doldurulması istenebilir.

        }

        private static void SavascilariListele()
        {
            //Kasabadaki tüm savascilar listesi
            foreach(object x in masukiye)
            {
                if(x is Savasci)
                {
                    Savasci s = (Savasci)x;
                    Console.WriteLine($"Savasci: {s.Name} Saldiri gücü:{s.Silah.SaldiriGücü}");

                }
            }
        }

        private static void KoyluleriListele()
        {
            //kasabadaki tüm köylüler listesi
            foreach (object x in masukiye)
            {
                if (x is Koylu)
                {
                    Koylu s = (Koylu)x;
                    Console.WriteLine($"Koylu: {s.Name}");

                }
            }

        }

        private static void Duelo()
        {
            //Kasabaya yeni gelen bir savasci diğer tüm savascilarla duello başlar taki 1 savasci kalana kadar.

            Savasci yeni = new Savasci("Gürol", new Silah(80));

            Random rand = new Random();
            while (Savasci.Canli_savasci_adet > 1)
            {
                int x = rand.Next(0, Savasci.Savasci_adet);
                if (yeni[x].Canlimi && !yeni.Equals(yeni[x]))
                {
                    yeni.Saldir(yeni[x]);
                    Console.WriteLine($"Saldirgan: {yeni.Name} Saldiri gücü:{yeni.Silah.SaldiriGücü}");
                    Console.WriteLine($"Maktul: {yeni[x].Name}");
                    if (yeni[x].Canlimi)
                    {
                        yeni[x].Saldir(yeni);
                        Console.WriteLine($"Saldirgan: {yeni[x].Name} Saldiri gücü:{yeni[x].Silah.SaldiriGücü}");
                        Console.WriteLine($"Maktul: {yeni.Name}");
                    }
                    while (!yeni.Canlimi)
                    {
                        x = rand.Next(0, Savasci.Savasci_adet);
                        yeni = yeni[x];
                    }
                }


            }

            Console.WriteLine($"Kazanan: {yeni.Name}");

        }
    }
}
