using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOrtalamasiHesaplama
{
    class Program
    {
        static double OrtalamaHesaplama(double birincivize, double ikincivize, double finalsinavi)
        {
            double ortalama = (birincivize + ikincivize + finalsinavi) / 3;
            return ortalama;
        }

        static double BesliSistemNotu(double bsn)
        {
            if (bsn >= 85.00 && bsn <= 100.00)
            {
                Console.WriteLine("5");
            }
            else if (bsn >= 70.00 && bsn <= 84.99)
            {
                Console.WriteLine("4");
            }
            else if (bsn >= 55.00 && bsn <= 69.99)
            {
                Console.WriteLine("3");
            }
            else if (bsn >= 45.00 && bsn <= 54.99)
            {
                Console.WriteLine("2");
            }
            else if (bsn >= 44.99 && bsn <= 0.00)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("Alınan not negatif olamaz.");
            }

            return bsn;
        }
        

        static double HarfNotuHesapla(double hn)
        {
            if (hn >= 90.00 && hn <= 100.00)
            {
                Console.WriteLine("AA");
            }
            else if (hn >= 85.00 && hn <= 89.99)
            {
                Console.WriteLine("BA");
            }
            else if (hn >= 80.00 && hn <= 84.99)
            {
                Console.WriteLine("BB");
            }
            else if (hn >= 70.00 && hn <= 79.99)
            {
                Console.WriteLine("CB");
            }
            else if (hn >= 60.00 && hn <= 69.99)
            {
                Console.WriteLine("CC");
            }
            else if (hn >= 55.00 && hn <= 59.99)
            {
                Console.WriteLine("DC");
            }
            else if (hn >= 50.00 && hn <= 54.99)
            {
                Console.WriteLine("DD");
            }
            else if (hn >= 40.00 && hn <= 49.99)
            {
                Console.WriteLine("FD");
            }
            else if (hn >= 0.00 && hn <= 39.00)
            {
                Console.WriteLine("FF");
            }
            else
            {
                Console.WriteLine("Alınan not negatif olamaz1.");
            }

            return hn;
        }

 
        static void Main(string[] args)
        {
            Console.WriteLine( "1. vize Notu: ");
            double vizebir = double.Parse(Console.ReadLine());
            Console.WriteLine("2. Vize Notu: ");
            double vizeiki = double.Parse(Console.ReadLine());
            Console.WriteLine("Final Notu: ");
            double final = double.Parse(Console.ReadLine());
            double avg = OrtalamaHesaplama(vizebir, vizeiki, final); ;
            Console.WriteLine("Ortalama: {0}", avg);
            double besli = BesliSistemNotu(avg);
            Console.WriteLine("5'li Sistem Karşılığı: {0}", besli);
            double harf = HarfNotuHesapla(avg);
            Console.WriteLine("Harf notu Karşılığı: {0}", harf);

            Console.ReadKey();
        }
    }
}
