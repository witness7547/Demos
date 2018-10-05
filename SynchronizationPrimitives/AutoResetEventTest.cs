using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    class Program
    {
        //static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        //static string dataFromServer = "";

        //static void Main(string[] args)
        //{
        //    Task.Factory.StartNew(() => { GetDataFormServer(); });

        //    // Put the current thread into waiting state until it receives the signal
        //    autoResetEvent.WaitOne();

        //    // Thread got the signal
        //    Console.WriteLine("Got data form server: " + dataFromServer);
        //    Console.ReadLine();
        //}

        //static void GetDataFormServer()
        //{
        //    // Calling any wedservice to get data
        //    Thread.Sleep(TimeSpan.FromSeconds(5));
        //    dataFromServer = "Webservice data";
        //    autoResetEvent.Set();
        //}
    }
}
