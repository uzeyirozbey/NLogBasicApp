using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Log logT = new Log();
            logT.StartTransaction();
            logT.DoSomething();
            logT.StopTransaction();
            Console.ReadLine();
        }
        class Log
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            public void StartTransaction()
            {
                logger.Info("Transaction başlatıldı.");
            }
            public void DoSomething()
            {
                logger.Fatal("servis çalışmıyor");
                logger.Error("db bağlantısı sağlanamadı.");
            }
            public void StopTransaction()
            {
                logger.Warn("Transaction sonlandı");
            }
        }
    }
}
