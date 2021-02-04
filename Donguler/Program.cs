using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";


            // array - dizi

            string[] kurslar = new string[] {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "java","Python","C#"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfa sonu - footer");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
