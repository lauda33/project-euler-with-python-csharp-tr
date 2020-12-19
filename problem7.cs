using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Project Euler Problem 7
                EN:By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
                What is the 10 001st prime number?

                TUR:İlk altı asal sayı:2, 3, 5, 7,11 ve 13'dır. Görebiliriz ki altıncı asal sayı 13'dür.
                10 001'inci asal sayı nedir?
             */
             //Bir sayı değişkeni oluşturuyoruz bunu 10001. asal sayıyı bulana kadar artıracağız. 
           int asalSayisi = 1;
           int sayi = 3;
            bool asalMi = true;
            while (true)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                //Asal kontrolü yapıyoruz asalsa asal sayısını artırıyoruz.
                if (asalMi)
                {
                    asalSayisi++;
                }
                //Asal sayısı istediğimiz sayıya ulaştığında döngüyü bitiriyoruz.
                if (asalSayisi == 10001)
                {
                    Console.WriteLine("10001. asal sayı: {0}", sayi);
                    break;
                }
                //Yeni sayıya geçip asal kontrolü için olan değişkenimizi sıfırlıyoruz.
                sayi++;
                asalMi = true;
            }
        }
    }
}
