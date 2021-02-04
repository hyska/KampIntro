using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrayler tanımlanırken index sınırlanır, genişletilemez
            //----stack------=-----heap------; 
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "İlker"; dersek hata verir
            // new demek yeni referans oluştur demek
            //isimler =new string[5];
            //isimler[4]="İlker"; dersek yeni array oluşturmuş olur
            //eski array gider

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
