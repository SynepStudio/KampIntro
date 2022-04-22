using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    
    {
        //naming convention
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!  :" + urun.Adi);

        }
        // yanlış yol ekle 2 sadece test amaçlıdır
        public void Ekle2(string urunAdi, string Aciklamasi, int Fiyati, int StokAdedi)
        {
            Console.WriteLine("Tebrikller Altarnatif Yönden Sepete Eklendi! :" +" "+ urunAdi);
        }
    }
}
