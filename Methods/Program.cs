using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var Urun in urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----------METOTLAR-----------");


            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



            // yanlış yol ekle 2 sadece test amaçlıdır.
            sepetManager.Ekle2("armut", "yeşil", 13,1);
            sepetManager.Ekle2("karpuz", "kıp kırmızı", 13, 32);
            sepetManager.Ekle2("kavun", "sap sarı", 13, 23);

        }
    }
}


//don't repeat yourSelf. (DRY)
