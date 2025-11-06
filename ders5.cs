using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneyeyonelikConsoleApp1
{
    internal class ders5
    {
        static void Main(string[] args)
        {
            ders5ogr o = new ders5ogr();
            Console.WriteLine("Öğrenci Adı Giriniz:"); 
            o.ogrAdı = Console.readline();
            Console.WriteLine("Öğrenci Soyadı Giriniz:");
            o.ogrsoyadı = Console.readline();
            Console.WriteLine("Öğrenci Numarası Giriniz:");
            o.ogrno = Console.readline();
            Console.WriteLine("\n\nOgrenci Bilgileri");

            Console.Writeline(o.ogrno);
            Console.Writeline(o.ogrAdı);
            Console.Writeline(o.ogrsoyadı);
            Console.Writeline(o.sinif);
            consol




            //kare.1.cs kodları
            /*kare k1 = new kare(5);
            kare k2 = new kare(3,4);
            */


        }
}
