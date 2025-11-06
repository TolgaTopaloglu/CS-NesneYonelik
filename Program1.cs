/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneyeyonelikConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
             Console.Write("merhaba dünya\n");//düz yazdırır 
             Console.WriteLine("merhaba dünya");//alt satıra geçer

             int sayi1 = 10;
             Console.WriteLine("GİRİLEN SAYİ={0}", sayi1);
             Console.WriteLine("GİRİLEN SAYİ=" + sayi1);
             Console.WriteLine(sayi1);                                              //DEĞİŞKEN TANIMLAMA-İF,ELSE-CASE        
             Console.WriteLine("BİR KELİME GİRİNİZ:");                              
             string kelime;
             kelime=Console.ReadLine();
             Console.WriteLine(kelime);

             Console.WriteLine("sayi giriniz:");
             int sayi2;
             sayi2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("GİRİLEN SAYİ={0}", sayi2);
             




//*********************2.HAFTA DERSİ*********************
for(int i = 0; i < 10; i++)
{
     Console.WriteLine(i);    
}

for (int k = 5; k <= 100; k++)        
{
    if (k % 5 == 0)
    {
        Console.WriteLine(k);
    }           
}


int a, b, toplam;
toplam = 0;
Console.WriteLine("baslangıc");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("bitis");
b=Convert.ToInt32(Console.ReadLine());
for (int i = a; i <= b; i++) {
    if (i % 2 == 0)
    {
        toplam = toplam + i;
    }
}
Console.WriteLine("sayiların toplamı={0}", toplam);



int sayac;
sayac = 0;
int toplam = 0;
while (sayac < 10)
{
    toplam = toplam + sayac;
    sayac++;
}
Console.WriteLine("toplam={0}", toplam);



int toplam = 0;
for(int i = 0; i <= 100; i++)
{
    if (i % 2 == 1)
    {                                           //0-100 ARASI SAYILARIN TOPLAMI
        toplam = toplam + i;
    }
}
Console.WriteLine(toplam);




Random rnd = new Random();
int a=rnd.Next(10);
int b;
int c=1;
while (true)
{                                                        
    Console.WriteLine("bir sayi giriniz:");            //1-10 ARASI RANDOM SAYI TUTMA VE O SAYIYI KAÇINCI TAHMİNDE BULMA
    b=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(c + ".tahmin="+b);
    if (a == b)
    {
        Console.WriteLine(c + ".tahmin doğru");
        break;
    }
    c++;


}


int a, b, saat, dk,sayac;
Random rand = new Random();
a = rand.Next(1000 , 9999);
dk = 0;
b = 1000;
sayac = 0;
do
{
    if (a == b)
    {
        Console.WriteLine("sifre bulundu:" + b);
        break;
    }
    b++;
    sayac++;
    if (sayac == 10)
    {
        dk = dk+15;
        sayac = 0;
    }

} while (b<=9999);
saat = dk / 60;
dk = dk % 60;
Console.WriteLine(saat + " saat" + dk + " dk sürdü");




}

















}
}
}*/
