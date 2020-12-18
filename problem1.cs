using System;
using System.Collections.Generic;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Project Euler Problem 1 
             EN:If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
             The sum of these multiples is 23.
             Find the sum of all the multiples of 3 or 5 below 1000.
            
             TUR:Eğer 10'un altındaki 3 veya 5'in katı doğal sayıları listelersek 3,5,6 ve 9 elde ederiz.
             Bu katların toplamı 23.
             1000'den küçük 3'ün veya 5'in katlarının toplamını bulun
             */
            List<int> katlar= new List<int>(); //katları tutacağımız listeyi oluşturuyoruz.
            //for döngüsü ile 1000 kadar olan sayıları döndürüyoruz.
            for (int i = 1; i < 1000; i++)
            {
                //3'e ya da 5'e bölündüğünde kalansız olan sayıları listemize ekliyoruz.
                if ((i%3 == 0) || (i % 5 == 0)) {
                    katlar.Add(i);
                }
            }
            //Son olarak listemizi yazdırıyoruz
            foreach (int kat in katlar)
            {
                Console.Write(kat+", ");
            }
        }
    }
}
