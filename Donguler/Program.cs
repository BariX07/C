using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kursu";
            string kurs2 = "programlamaya başlangıç için temel kurs";

            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kursu",
                    "programlamaya başlangıç için temel kurs",
                    "java","python"} ;

            for (int i = 0; i < kurslar.Length; i++)        //kurslardaki hepsini dolandırdık 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)        //tek tek dolaşmaya yarıyor
            {
                Console.WriteLine(kurs)
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
