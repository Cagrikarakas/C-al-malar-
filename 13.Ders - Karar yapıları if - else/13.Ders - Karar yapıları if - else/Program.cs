using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Ders___Karar_yapıları_if___else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınav Notunuzu Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 65)
            {
                Console.WriteLine("Tebrikler Sınavı Geçtiniz!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Sınav Sonucu: Başarısız!");
                Console.ReadLine(); 
            }
        }
    }
}
