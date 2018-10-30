
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /// <summary>
    /// 综合使用析构函数（以防为调用dispose方法）和dispose方法（实时释放资源）来实现非托管资源的释放
    /// </summary>
    class MyResource : IDisposable
    {
        private IntPtr handle;

        private Component component = new Component();

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispoding)
        {
            if (!disposed)
            {
                if (dispoding)
                {
                    component.Dispose();
                }

                CloseHandle(handle);
                handle = IntPtr.Zero;
                
                disposed = true;
            }
        }

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle); 

        /// <summary>
        /// 析构函数会被编译器转换为Finalize(终结器)方法
        /// </summary>
        ~MyResource()
        {
            Dispose(false);
        }
    }
}
