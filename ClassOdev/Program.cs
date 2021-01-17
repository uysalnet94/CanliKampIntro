using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Toshiba Bilgisayar";
            urun1.UrunKategori = "Bilgisayar";
            urun1.Stok = 68;
            urun1.UrunFiyat = 5865.99F;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Aklından Bir Sayı Tut";
            urun2.UrunKategori = "Kitap";
            urun2.Stok = 55;
            urun2.UrunFiyat = 25.99F;


            Urun urun3 = new Urun();
            urun3.UrunAdi = "Siemens TV";
            urun3.UrunKategori = "Televizyon";
            urun3.Stok = 25;
            urun3.UrunFiyat = 685.99F;


            Urun urun4 = new Urun();
            urun4.UrunAdi = "Bilgisayar Çantası";
            urun4.UrunKategori = "Çanta";
            urun4.Stok = 15;
            urun4.UrunFiyat = 99.99F;

            //Console.WriteLine(Urun1.UrunAdi + ";" + Urun1.Egitmen);


            Urun[] Urunler = new Urun[] { urun1, urun2, urun3, urun4 };
            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine("Adı : " + Urunler[i].UrunAdi);
                Console.WriteLine("Kategori : " + Urunler[i].UrunKategori);
                Console.WriteLine("Stok : " + Urunler[i].Stok);
                Console.WriteLine("Fiyat : " + Urunler[i].UrunFiyat + "\n");

            }
            Console.WriteLine("-------------------------------");

            foreach (var Urun in Urunler)
            {
                Console.WriteLine("Adı : " + Urun.UrunAdi);
                Console.WriteLine("Kategori : " + Urun.UrunKategori);
                Console.WriteLine("Stok : " + Urun.Stok);
                Console.WriteLine("Fiyat : " + Urun.UrunFiyat + "\n");
            }

            Console.WriteLine("-------------------------------");
            int length = 0;
            while (length < Urunler.Length)
            {

                Console.WriteLine("Adı : " + Urunler[length].UrunAdi);
                Console.WriteLine("Kategori : " + Urunler[length].UrunKategori);
                Console.WriteLine("Stok : " + Urunler[length].Stok);
                Console.WriteLine("Fiyat : " + Urunler[length].UrunFiyat + "\n");
                length++;

            }
            Console.WriteLine("-------------------------------");
        }

    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunKategori { get; set; }
        public int Stok { get; set; }
        public float UrunFiyat { get; set; }
    }
}

