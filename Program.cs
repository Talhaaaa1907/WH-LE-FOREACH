using System;

namespace WHİLE_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            //1'den başlayarak console'dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console'a yazdıran program
            int sayac = 1;
            int toplam = 0;
            Console.WriteLine("Bir sayı giriniz...");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: " + toplam / sayi);


            //a'dan z'ye kadar tüm harfleri console'a yazdır.
            char karakter = 'a';
            while (karakter < 'z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }


            //Foreach
            string[] arabalar = { "BMW", "Mercedes", "Wolksvagen", "Audi" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadLine();
        }
    }
}
