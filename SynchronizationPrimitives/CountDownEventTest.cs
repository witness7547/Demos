using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    class CountDownEventTest
    {
        //static void Main(string[] args)
        //{
        //    CountdownEvent countdownEvent = new CountdownEvent(10);

        //    int[] result = new int[10];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        int j = i;
        //        Task.Factory.StartNew(() =>
        //        {
        //            Thread.Sleep(TimeSpan.FromSeconds(3));
        //            result[j] = j * 10;
        //            countdownEvent.Signal();
        //        });
        //    }

        //    countdownEvent.Wait();

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}
    }
}
