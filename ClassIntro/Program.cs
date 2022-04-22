using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            kurs kurs1 = new kurs();
            kurs1.Egitmeni = "efe";
            kurs1.KursAdi = "Tester";
            kurs1.IzlenmeOrani = 900;


            kurs kurs2 = new kurs();
            kurs2.Egitmeni = "efe2";
            kurs2.KursAdi = "Studio";
            kurs2.IzlenmeOrani = 100;


            kurs kurs3 = new kurs();
            kurs3.Egitmeni = "efe3";
            kurs3.KursAdi = "Blender";
            kurs3.IzlenmeOrani = 400;


            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" : "+ kurs.Egitmeni);
            }
        }
    }

 class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public double IzlenmeOrani { get; set; }
    }

}
