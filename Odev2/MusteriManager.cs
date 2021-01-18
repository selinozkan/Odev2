using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class MusteriManager
    {

        public void ekle(Musteri musteri)
        {
            Console.WriteLine("KAYITLI MÜŞTERİLERİMİZ");
            Console.WriteLine("                     ");
            Console.WriteLine("adı:" + musteri.Adi);
            Console.WriteLine("soyadı :" + musteri.Soyadi);
            Console.WriteLine("sehir: " + musteri.Sehir);
            Console.WriteLine("id: " + musteri.Id);
            Console.WriteLine("                     ");
        }
        public void yeni(string kisiadi, string soyadi, string sehir, int id)
        {

            Console.WriteLine("YENİ ÜYE EKLENDİ!!!");
            Console.WriteLine("adı:" + kisiadi);
            Console.WriteLine("soyadı :" + soyadi);
            Console.WriteLine("sehir: " + sehir);
            Console.WriteLine("id: " + id);
            Console.WriteLine("                     ");
        }

        public void silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " silindi ");

        }
    }
}
