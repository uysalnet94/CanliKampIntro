using System;

namespace CanliKampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenler veri tutuculardır. Veri yönetimionlarla yönetilir.
            //type safety önemli
            //Do not repeat yourself
            //kategoriEtiketi = değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool isLogOn = true;
       
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarBugun < dolarDun)

            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }


            {

            }




            if (isLogOn == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
               



        }
    }
}
