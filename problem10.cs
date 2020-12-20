using System;

namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problem 10
                EN:The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
                Find the sum of all the primes below two million.

                TR: 10'dan küçük asal sayıların toplamı 2+3+5+7 = 17'dir.
                2 Milyonun altındaki asal sayiların toplamını bulunuz.
             */
            int sayi = 2;
            long toplam = 2;
            bool asalMi = true;
            while (sayi<2000000)
            {
                sayi++;
                asalMi = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    toplam += sayi;
                }
            }
            Console.WriteLine("2 milyondan küçük asal sayıların toplamı: {0}",toplam);
            //Deneme yapılacak !!!
        }
    }
}
