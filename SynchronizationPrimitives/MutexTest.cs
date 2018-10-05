using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    class MutexTest
    {
        static void Main(string[] args)
        {
            bool createdNew;
            Mutex mutex = new Mutex(false, "MyMutex", out createdNew);

            if (!createdNew)
            {
                Console.WriteLine("You can only start one instance of the Application");
                return;
            }

            Console.WriteLine("This is MutexTest App!");
            Console.ReadLine();
        }
    }
}
