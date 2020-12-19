using System;
using System.Collections.Generic;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Project Euler Problem 4
                EN:A palindromic number reads the same both ways. 
                The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
                Find the largest palindrome made from the product of two 3-digit numbers.
                
                TUR: Palindrom bir sayı her yönden aynı şekilde okunur.
                İki iki basamaklı sayının çarpılması sonucu oluşan en büyük palindrom sayı 9009'dur 
                İki üç basamaklı sayının çarpılması sonucu oluşacak en büyük palindrom sayıyı bulun
             */
            List<int> polindromSayilar = new List<int>();
            int sayi;
            string strSayi;
            bool polindromMu = true;
            //3 basamaklı en büyük sayıdan başlayarak ve iki tane for döngüsü kullanarak sayıları aramaya başladık.
            for (int i = 999; i >99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    sayi = i * j; //Döngülerde sırayla dönen 2 sayının çarpımını aldık.
                    strSayi = sayi.ToString();
                    //Polindrom olup olmadığını kontrol etmek için simetrik olarak baştan ve sondan aynı sırada bulunan sayıların değerlerini karşılaştırdık.
                    for (int k = 0; k < strSayi.Length; k++)
                    {
                        //Eğer değerler birbirine eşit değilse kontrolü sonlardırdık ve diğer sayının çarpımını baktık.
                        if (strSayi[k] != strSayi[(strSayi.Length-1)-k])
                        {
                            polindromMu = false;
                            break;
                        }
                    }
                    //Eğer sayımızı bulduysak:
                    if (polindromMu)
                    {
                        polindromSayilar.Add(sayi); //Bulduğumuz polindrom sayıyı oluşturduğumu listemize attık.
                    }
                    polindromMu = true; //Tekrar kontrol etmek için değerimizi true yaptık.
                }
            }
            polindromSayilar.Sort(); //Listemizdeki elemanları küçükten büyüğe doğru sıraladık ve son elemanı konsola yazdırdık.
            Console.WriteLine("3 basamklı sayıların çarpılması sonucu oluşan en büyük polindrom sayı: {0}", polindromSayilar[polindromSayilar.Count-1]);
        }
    }
}
