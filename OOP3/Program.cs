using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
            //polimorphism
            //Interfaceler de implement eden classların referans numaralarını tutar
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
        
    }
}
