using System;

namespace problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            EN:Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
            How many such routes are there through a 20×20 grid?

            TR:2x2’lik aşağıdaki gibi bir yolun sol üstünden başlayarak ve sadece sağa ve aşağı hareket ederek, tam 6 değişik güzergah ile sağ alt köşeye varılabilir.
            Bu kurallarda, 20x20’lik bir yolsa kaç farklı güzergah vardır?

            Açıklama: Bu soruyu tekrarlı permütasyon ile çözeceğiz. 20x20'lik bir yol olduğu için 20 kez sağa 20 kez aşağıya hamle yapmalıyız. Yani toplam 40 hamle yapmalıyız.
            Örneğe bakarsak 2x2'lik yolda 2 kez sağa 2 kez aşağı gitmemiz gerekir toplam hareket 4 olur. 4!/(2!*2!) işlemi ile 6 farklı güzergah olduğunu bulabiliriz.
            Bu soruyu ise 40!/20!*20! işlemi ile çözeceğiz. 
             */
            int yolBoyu1 = 20;
            double faktoriyelYol = 1;
            double yolBoyu2 = yolBoyu1;
            double _toplamYol= yolBoyu1*2;
            //While döngümüze koyduğumuz şart ile ilk bölme işlemini yaptırmış oluyoruz.
            while (_toplamYol > yolBoyu1)
            {
                //Hem bölünen hem de bölen faktoriyelli olduğu için faktoriyel işlemlerini yaparken önce bölme işlemi yapıyoruz sonra faktoriyel değişkenimizle çarpıyoruz.
                //Tabii ki bu işlemi bölenimiz 0 olana kadar yapıyoruz.
                if (yolBoyu2 > 0)
                {
                    faktoriyelYol *= (_toplamYol /yolBoyu2);
                    yolBoyu2--;
                }
                else
                {
                    faktoriyelYol *= _toplamYol;
                }
                _toplamYol--;
            }
            //Bulduğumuz sonucu ekrana yazdırıyoruz.
            Console.WriteLine(faktoriyelYol);
           
        }
    }
}
