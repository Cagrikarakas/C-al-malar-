using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_kullanıcıdan_Değer_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminizi Giriniz:");
            string soyisim = Console.ReadLine();

            Console.Write("Kullanıcı Bilgileri: " + isim + " " + soyisim);
           



            Console.ReadLine();

        }
    }
}
