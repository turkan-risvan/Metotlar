using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string uruAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyat = 20;
            urun2.Aciklama = "Ayı Armudu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");

            }
            Console.WriteLine("-------Metotlar-------");

            //instanc-örnek
            //encapsulation-kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 10, 3);
            sepetManager.Ekle2("Elma", "Kırmız Elma", 13, 4);
            sepetManager.Ekle2("Muz", "Anamur Muzu", 12, 5);
        }
    }
}
// Dont repeat yourself- kendini tekrar etme
// clean code - temiz kod
// pest pratice 
