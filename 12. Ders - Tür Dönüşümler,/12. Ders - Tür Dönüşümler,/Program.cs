using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Ders___Tür_Dönüşümler_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string değişkenini kullanarak kullanıcıdan verileri aldık. Ardından Tür dönüşümünü ToInt32 
            // Metodunu kullanarak girilen bilgileri tam sayı olarak topladık.

            /*Console.WriteLine("Sayı giriniz:");
            string ad = Console.ReadLine();

            Console.WriteLine("2.Sayıyı giridiniz:");
            string soyad = Console.ReadLine();
            
            int AdSayisi = Convert.ToInt32(ad);
            int SoyadSayisi = Convert.ToInt32(soyad);

            Console.WriteLine("Toplam Sonuç:" + (AdSayisi + SoyadSayisi));
            Console.ReadLine(); */


            /*  int a = 1;

              float b = (float)a;

              Console.WriteLine(b.GetType());
              Console.WriteLine(b);
              Console.ReadLine();  */

            /*
             * int say1 = 5;
              int say2 = 10;

              string a = say1.ToString();
              string b = say2.ToString();

              Console.WriteLine(b+a);
              Console.ReadLine();
              */

            Console.WriteLine("En sevdiğin ondalıklı gir :");
            double sayi = Convert.ToDouble(Console.ReadLine());
            int sonuc = (int)sayi;
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
