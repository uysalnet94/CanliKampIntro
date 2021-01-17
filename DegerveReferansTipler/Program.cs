using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int,decimal,dloat,double, bool değer tiptir.
            //Değer tip olan işlemler Belleğin Stack kısmında gerçekleşmektedir.
            //Referans tipli işlemler ise belleğin Heap kısmında gerçekleşmektedir.
            //Değer tiplerde eşitlikte değerler atanır, 
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine("Sayı 1 = " + sayi1);
            //test kontrol 



            //array,class,interface referans tiptir.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //Referans tip olduğu için sayilar2 de yapılan değişiklik sayilar1 arrayini etkilemektedir.
            //Referans tiplerde eşitliklerde referans numarası atanır. sayilar1 = sayilar2 dediğimizde sayilar2 ye ait referans kodu sayilar1e atanmıştır.

            Console.WriteLine("Sayılar 1 in ilk elemanı : " + sayilar1[0]);
        }
    }
}
