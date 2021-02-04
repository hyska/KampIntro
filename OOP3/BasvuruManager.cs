using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // interface clasın referansını tuttuğu için
        // BasvuruYap(KonutKredisi) derse konut kredisi
        //BasvuruYap(Tasıt Kredisi) derse Taşıt kredisi hesaplanır
        //Method injection sonradan loglama eklemesi
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Basvuran Bilgilerini Değerlendirme
            //
            //
            //
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
