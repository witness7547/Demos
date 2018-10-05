using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    class BarrierTest
    {
        //static Barrier barrier = new Barrier(participantCount:5);

        //static void Main(string[] args)
        //{
        //    Task[] tasks = new Task[5];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        tasks[i] = Task.Factory.StartNew(() => 
        //        {
        //            GetDataFromServer(i);
        //        });
        //    }

        //    Task.WaitAll(tasks);

        //    Console.WriteLine("Backup completed!");
        //    Console.ReadLine();
        //}

        //static void GetDataFromServer(int index)
        //{
        //    Console.WriteLine("Get data from server:" + index);
        //    Thread.Sleep(TimeSpan.FromSeconds(2));

        //    barrier.SignalAndWait();

        //    Console.WriteLine("Send data to backup server:" + index);

        //    barrier.SignalAndWait();
        //}
    }
}
