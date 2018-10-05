using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    class SemaphoreTest
    {
        static void Main(string[] args)
        {
            Semaphore semaphore = new Semaphore(initialCount: 3, maximumCount: 3, name: "PrinterApp");
            Printer printer = new Printer();

            for (int i = 0; i < 20; i++)
            {
                int j = i;//???

                Task.Factory.StartNew(() =>
                {
                    semaphore.WaitOne();
                    printer.Print(j);
                    semaphore.Release();
                });
            }

            Console.ReadLine();
        }
    }

    class Printer
    {
        public void Print(int docToPrint)
        {
            Console.WriteLine("Printing document:" + docToPrint);
            // Code to print document
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
