using System;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Project Euler Problem 9
                EN:A Pythagorean triplet is a set of three natural numbers, a < b < c, for which a^2 + b^2 = c^2
                For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
                There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.

                TUR: Bir pisagor üçgeni 3 doğal sayı içeren (a<b<c olacak şekilde a^2+b^2 = c^2 kuralının karşılayan) bir kümedir.
                a+b+c = 1000 kuralını karşılayan sadece bir üçgen vardır, üçgenin kenarları çarpımını bulun.
            */
            int a = 2, b = 1;
            double c;
            bool buldukMu = false;
            while (true)
            {
                for ( b = 0; b < a; b++)
                {
                    c = Math.Sqrt((b * b) + (a * a));
                    if (a+b+c == 1000)
                    {
                        Console.WriteLine("Toplamları 1000 yapan ve verilen şartı sağlayan üçlümüz: {0}, {1}, {2}",a,b,c);
                        Console.WriteLine("Çarpımları: {0}", a*b*c);
                        buldukMu = true;
                        break;
                    }
                }
                if (buldukMu)
                {
                    break;
                }
                a++;
            }
        }
    }
}
