using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //3773

            string Aliyasmıne = "Kırk beş";
            int SiraNumarasi = 31;
            Double ogrenciSayisi = 31.31;
            Boolean limon = false;
            Double dolarBugün = 8.92;
            double dolarYarın = 8.92;
            if (dolarBugün > dolarYarın)
            {
                Console.WriteLine("Dolar Azalmış");

            }
            else if (dolarBugün<dolarYarın)
            {
                Console.WriteLine("artmış");
            }
            else
            {
                Console.WriteLine("bir şey değişmemiş");
            }
           




            if (limon == true)
            {
                Console.WriteLine("taze değil");
            }
            else
            {
                Console.WriteLine("taze limon");    
            }

          
        }
    }
}
