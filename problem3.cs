using System;
using System.Collections.Generic;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Project Euler Problem 3
                EN:The prime factors of 13195 are 5, 7, 13 and 29.
                What is the largest prime factor of the number 600851475143 ?
               
                TUR:13195'in asal çarpanları 5,7,13 ve 29'dur.
                600851475143 sayısının en büyük asal çarpanı nedir?
              */
            long sayi = 600851475143;
            bool asalMi = true;
            for (long i = sayi; i >= 1; i--)
            {
                if (sayi % i == 0)
                {
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }
                    if (asalMi)
                    {
                        Console.WriteLine("En büyük asal çarpan: {0} sayısıdır.", i);
                        break;
                    }
                    asalMi = true;
                }
            }
           
        }
    }
}
