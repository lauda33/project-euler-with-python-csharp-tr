using System;
using System.Numerics;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Problem 16
                 En: 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
                 What is the sum of the digits of the number 2^1000?

                TR: 2^15 = 32768 ve basamaklarının toplamı 3 + 2 + 7 + 6 + 8 = 26 ise;
                2^1000 sayısının basamakları toplamı kaçtır ?
              */
            BigInteger sayi = BigInteger.Pow(2, 1000);
            //Tip double olduğunda sayı 1,07186071862673E+301 geliyor. Bu gelen değeri stringden int'e çeviremiyoruz bu nedenle BigInteger kullanıyoruz.
            int toplam = 0;
            string _sayi = sayi.ToString(); //Basamkları alabilmek için stringe çeviriryoruz.
            for (int i = 0; i < _sayi.Length; i++)
            {
                toplam += int.Parse(_sayi[i].ToString());
            }
            Console.WriteLine(toplam);
        }
    }
}
