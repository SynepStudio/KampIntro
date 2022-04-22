using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayı = 10;

            string[] kurslar = new string[] {"noodle", "et yeme kursu", "Vegan kursu" };

            for (int i  = 0; i  < kurslar.Length; i ++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string Kurs in kurslar)
            {
                Console.WriteLine(Kurs);
            }
        }

    }
}
