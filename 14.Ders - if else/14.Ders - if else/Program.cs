using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders___if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sınav Sonucunu Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sınav Sonucunu Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sınav Sonucunu Giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int sonuc = (sayi1 + sayi2 + sayi3) / 3;

            if (sonuc >= 80 && sonuc <= 100)
            {
                Console.WriteLine("Notunuz : A+");
                Console.ReadLine();
            }
            else if (sonuc >= 60 && sonuc < 80)
            {
                Console.WriteLine("Notunuz : B");
                Console.ReadLine();
            }
            else if (sonuc >= 40 && sonuc < 60)
            {
                Console.WriteLine("Notunuz : C");
                Console.ReadLine();
            }
            else if (sonuc >= 20 && sonuc < 40)
            {
                Console.WriteLine("Notunuz : D");
                Console.ReadLine();
            }
            else if (sonuc >= 0 && sonuc < 20)
            {
                Console.WriteLine("Notunuz : F");
                Console.ReadLine();
            }
        }
    }
}
