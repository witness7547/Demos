using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationPrimitives
{
    /*

    lock (x)
    {
        // Your code...
    }


    object __lockObj = x;
    bool __lockWasTaken = false;
    try
    {
        System.Threading.Monitor.Enter(__lockObj, ref __lockWasTaken);
        // Your code...
    }
    finally
    {
        if (__lockWasTaken) System.Threading.Monitor.Exit(__lockObj);
    }

    当同步对共享资源的线程访问时，请锁定专用对象实例（例如，private readonly object balanceLock = new object();）
或另一个不太可能被代码无关部分用作 lock 对象的实例。 避免对不同的共享资源使用相同的 lock 对象实例，因为这可能导致死锁或锁争用。 具体而言，应避免使用
1.this（调用方可能将其用作 lock），
2.Type 实例（可以通过 typeof 运算符或反射获取），
3.字符串实例，包括字符串文本，
用作 lock 对象。
    */
    class LockTest
    {
        //Monitor
    }
}
