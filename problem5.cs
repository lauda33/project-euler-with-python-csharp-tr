using System;
using System.Collections.Generic;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Project Euler Problem 5
                
            EN:2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
             
            TUR: 2520 1 den 10 a kadar tüm sayıların kalansız bölündüğü en küçük sayıdır
            1'den 20'ye kadar tüm sayıların kalansız böldüğü en küçük sayı nedir?
            */
            int ekok=1;
            int ekokBul(int sayi1, int sayi2)
            {
                //ekok = sayıların çarpımı / ebob
                int _ebob = 1, _ekok = 1;
                //ebob bulmak için sayılarımızdan büyük olanını alıp bir bir azaltıyoruz ve her iki sayıyı da bölebilen bir sayı arıyoruz.
                for (int i = Math.Max(sayi1, sayi2); i > 1; i--)
                {
                    //sayıyı bulduğumuzda
                    if (sayi1 % i == 0 && sayi2 %i == 0)
                    {
                        //sayıyı eboba eşitliyoruz
                        _ebob = i;
                        //Çarpım int değerlerini aşabileceğinden eğer ebob sayılardan küçük olana eşitse ekok büyük olandır diye bir işlem yapıyoruz. Altta daha detaylı...
                        if (_ebob == Math.Min(sayi1,sayi2))
                        {
                            return Math.Max(sayi1,sayi2);
                        }
                        break;
                    }
                }
                //Eğer ebob sayılardan küçük olana eşit değilse döngü bitirilir ve sayıların çarpımı / ebob formülünden ekok bulunur
                _ekok = ((sayi1 * sayi2) / _ebob);
                return _ekok;
            }
            //Sırasıyla 2'den 20'ye kadar olan sayıları alıp ekoklarını buluyoruz. Aşağıda daha detaylı...
            for (int i = 2; i < 21; i++)
            {
                ekok = ekokBul(i,ekok);
            }
            Console.WriteLine("sonuç: " + ekok);
        }    
    }
}
/*
 Ebob ekok için açıklama:
    Eğer iki sayının en büyük ortak böleni yani ebobu küçük olanına eşitse iki sayı büyük olan sayıda birleşir.
    Örneğin: 2 ve 4 sayıları küçük olan ebob (İki sayımız da 2'ye bölünebilir.) bbu sayılar ise 4 sayısında birleşir yani ortak katı 4'tür.
    Not: Bunu yapmamın amacı çarpım durumunda int veri tipinin değer aralığından daha fazla değer almaya çalışmasıdır.

 Ekok için açıklama:
    Sırasıyla sayıları ve ekokları buluyoruz işlem şöyle işliyor sayımız 2 ekokumuzun ilk değeri 1 ise 2 ve 1'in ekoku 2'dir. Bunu bulup ekok değişkenimize atarız ve sıra 3'e gelir.
    Bu sefer 3 ve 2'nin (önceki ekok değerimiz) ekokunu buluruz bu da 6 yapar ekok değişkenini 6 yaparız ve sıra 4'e geçer. 4 ile önceki ekok değerimiz olan 6'nın ekokunu buluruz... 
    İşlemler böyle devam eder gider.
*/
