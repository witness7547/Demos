using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Worker);
            t.IsBackground = true;
            t.Start();


            //如果t是前台线程，则该程序大约过5秒后才终止
            //如果t是后台线程，则应用程序立即终止
            Console.WriteLine("Returning from Main!");
        }

        public static void Worker()
        {
            Thread.Sleep(5000);

            Console.WriteLine("Returning from worker!");
        }
    }
}
