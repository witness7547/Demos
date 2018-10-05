using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    class ManualResetEventTest
    {
        //static ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        //static void Main(string[] args)
        //{
        //    Task.Factory.StartNew(() => { GetDataFromServer(1); });

        //    Task.Factory.StartNew(() => { GetDataFromServer(2); });

        //    manualResetEvent.Set();
        //    manualResetEvent.Reset();

        //    Thread.Sleep(TimeSpan.FromSeconds(2));

        //    manualResetEvent.Set();

        //    Console.ReadLine();
        //}

        //static void GetDataFromServer(int serverNumber)
        //{
        //    Console.WriteLine("Get first data from server " + serverNumber.ToString());
        //    manualResetEvent.WaitOne();

        //    Thread.Sleep(TimeSpan.FromSeconds(2));


        //    Console.WriteLine("Get second data from server " + serverNumber.ToString());
        //    manualResetEvent.WaitOne();

        //    Console.WriteLine("All the data collected form server" + serverNumber);
        //}
    }
}
