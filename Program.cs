using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeYonelik5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o=new Class1();
            Console.WriteLine("Öğrenci İsmi:");
            o.ograd = Console.ReadLine();
            Console.WriteLine("Öğrenci Soyad:");
            o.ogrsoyad = Console.ReadLine();
            Console.WriteLine("Öğrenci Numarası:");
            o.ogrno = Console.ReadLine();
            Console.WriteLine("\n\nÖğrenci Bilgileri");

            Console.WriteLine(o.ogrno);
            Console.WriteLine(o.ograd);
            Console.WriteLine(o.ogrsoyad);
            Console.WriteLine(o.Sinif);

            Console.WriteLine("\n\n");
            kare k1 = new kare(5);
            kare k2=new kare(5, 10);



        }
    }
}
