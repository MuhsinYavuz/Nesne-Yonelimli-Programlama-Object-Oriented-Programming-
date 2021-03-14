using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            BasvuruManager basvuruManager = new BasvuruManager();
        //    basvuruManager.BasvuruYap(ihtıyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtıyacKrediManager,taşıtKrediManager };
        //    basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            ILogerService FileLogger = new FileLoggerService();
            ILogerService DataLogger = new DatabaseLoggerService();
            ILogerService SmsLogeer = new SmsLoggerService();
            basvuruManager.BasvuruYap(esnafKrediManager,new List<ILogerService> {DataLogger,SmsLogeer,FileLogger });

        }
    }
}
