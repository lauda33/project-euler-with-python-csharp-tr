using System;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
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
