using System;
namespace problem14
{
    class Program
    {
        /*
         Project Euler Problem 14
         
            EN:The following iterative sequence is defined for the set of positive integers:
            n → n/2 (n is even)
            n → 3n + 1 (n is odd)
            Using the rule above and starting with 13, we generate the following sequence:  13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
            Which starting number, under one million, produces the longest chain?
            NOTE: Once the chain starts the terms are allowed to go above one million.

            TR: Pozitif tam sayılar için aşağıdaki kurala göre bir dizi tanımlanmıştır:
            n → n/2 (n çift)
            n → 3n + 1 (n tek)
            Yukarıdaki kuralı uygulayarak ve 13’ten başlayarak aşağıdaki diziyi üretiriz:  13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            13’ten başlayıp 1’de sonlanan bu dizinin 10 adet terim içermektedir.. Henüz kanıtlanmış olmasa da(Collatz Problemi), bütün başlangıç sayılarının 1’de sonuçlanacağı sanılmaktadır.
            Bir milyonun altındaki hangi başlangıç sayısı, en uzun zinciri üretir?
            NOT: Zincir bir kere başladıktan sonra terimlerin 1 milyonun üzerine çıkabilmesi mümkündür.
             */
        static void Main(string[] args)
        {
            int zincirUzunlugu = 1, enUzunZincirinBasi = 1, enUzunZincirUzunlugu = 0;
            long  terim;
            for (int i = 2; i < 1000000; i++)
            {
                terim = i;//Başlangıç terimi olarak döngümüzdeki i değerini alıyoruz
                zincirUzunlugu = 1; //Zincir uzunluğumuzu sıfırlıyoruz 1 dememizin sebebi ilk terimi de hesaba katmamız
                while (terim != 1) //Tüm diziler 1'de bittiği için 1'e eşit olmadığı sürece diziyi devam ettiriyoruz.
                {
                    //Terimimizn çift olup olmadığını kontrol ediyoruz ve kurala uygun bir biçimde diziyi ilerletiyoruz.
                    if (terim % 2 == 0)
                    {
                        terim = terim / 2; 
                    }
                    else
                    {
                        terim = 3 * terim + 1;
                    }
                    zincirUzunlugu++;
                }
                //Bulduğumuz son uzunluk en uzun zincirin uzunluğundan büyükse en uzun zincirin uzunluğunu ve başlangıç sayısını alıyoruz.
                if (zincirUzunlugu > enUzunZincirUzunlugu)
                {
                    enUzunZincirinBasi = i;
                    enUzunZincirUzunlugu = zincirUzunlugu;
                }
            }
            Console.WriteLine(enUzunZincirinBasi+"'dan başlayan dizinin uzunluğu: "+enUzunZincirUzunlugu);
        }
    }
                
}
