using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders___object_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object veri tipi tüm veri tiplerinin atasıdır. Hepsini kap

            object a = 10;
            object b = "Yusuf";
            object c = 12.32;
            object d = 'A';

            Console.WriteLine(a);
            Console.WriteLine(b);  
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.ReadLine(); 
        }
    }
}
