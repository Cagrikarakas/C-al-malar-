using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ders___byte_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = 02;
            byte sayi2 = 03;
            byte maks = byte.MaxValue; // en yüksek byte değerini veriyor = 255.
            byte min = byte.MinValue; // en düşük byte değerini veriyor = 0.

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(maks);
            Console.WriteLine(min);

            Console.ReadLine(); //Konsolun açık kalmasına yarıyor.
        }
    }
}
