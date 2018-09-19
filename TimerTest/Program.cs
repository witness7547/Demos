/*
    //线程池执行
    System.Threading.Timer
    System.Timers.Timer（相当于对System.Threading.Timer的包装）

    //UI定时器(和调用线程关联，将一条计时器消息（WM_TIMER）注入线程的消息队列)
    System.Windows.Forms.Timer（winform）
    System.Windows.Threading.DispatcherTimer(WPF， silverlight)
    Windows.UI.Xaml.DispatcherTimer(Windows Store)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerTest
{
    class Program
    {
        /*
        internal static Timer s_timer;//namespace is System.Threading

        static void Main(string[] args)
        {
            Console.WriteLine("checking status every 2 seconds");

            s_timer = new Timer(Status, null, Timeout.Infinite, Timeout.Infinite);

            s_timer.Change(0, Timeout.Infinite);


            Console.ReadLine();
        }

        private static void Status(object state)
        {
            Console.WriteLine("In status at {0}", DateTime.Now);
            Thread.Sleep(1000);//模拟工作1秒

            //返回前让Timer在2秒后再次触发
            s_timer.Change(2000, Timeout.Infinite);

            //这个方法返回后，线程回归线程池中，等待下一个工作项。
            
        }*/
    }
}
