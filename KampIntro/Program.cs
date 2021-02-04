using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type Safety c# java veri türü konusunda katıdır.
            // Do not repeat yourself
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.45;
            double dolarBugun = 7.35;            

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
        }
    }
}
