using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "GÜLSELİ";
            musteri1.Soyadi = "DENİZ";
            musteri1.Id = 1;
            musteri1.Sehir = "İZMİR";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "ORHAN";
            musteri2.Soyadi = "GÖK";
            musteri2.Id = 2;
            musteri2.Sehir = "ANTALYA";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "TURGUT";
            musteri3.Soyadi = "ÖZBEN";
            musteri3.Id = 3;
            musteri3.Sehir = "İSTANBUL";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach( Musteri x in musteriler)
            {
                Console.WriteLine("müşteri adı: " + x.Adi);
                Console.WriteLine("müşteri soyadı: " + x.Soyadi);
                Console.WriteLine("müşteri id : " + x.Id);
                Console.WriteLine("şehir: " + x.Sehir);
                Console.WriteLine("                  ");
                Console.WriteLine("                  ");
            }


            
            MusteriManager y = new MusteriManager();
            y.ekle(musteri1);
            y.ekle(musteri2);
            y.ekle(musteri3);
            y.yeni("ZEYNEP", "KAYA", "ANKARA", 4);
            y.silme(musteri1);
        }

      
    }
}
