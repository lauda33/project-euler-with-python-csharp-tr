using System;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Project Euler Problem 6

            EN:The sum of the squares of the first ten natural numbers is 1^2 + 2^2 +...+ 10^2 = 385,
            The square of the sum of the first ten natural numbers is (1+2+...+10)^2 = 55^2 = 3025,
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            TR:İlk on doğal sayının kareleri toplamı 1^2 + 2^2 +...+ 10^2 = 385'dir,
            İlk on doğal sayının toplamının karesi (1+2+...+10)^2 = 55^2 = 3025'dir,
            İlk on doğal sayının toplamlarının karesi ve karelerinin toplamının farkı 3025-385'den 2640'dır.
            İlk yüz doğal sayının toplamlarının karesinin ve karelerinin toplamının farkını bulunuz.
             */
            int toplamlarinKaresi,karelerininToplami=0, sayilarinToplami=0, fark;
            for (int i = 1; i <= 100; i++)
            {
                karelerininToplami += i * i;
                sayilarinToplami += i;
            }
            toplamlarinKaresi = sayilarinToplami * sayilarinToplami;
            fark = toplamlarinKaresi - karelerininToplami;
            Console.WriteLine("İlk 100 doğal sayının toplamlarının karesinin farkı ile karelerinin toplamının farkı: {0} sayısıdır.",fark);
        }
    }
}
