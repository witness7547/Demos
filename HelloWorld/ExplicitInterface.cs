using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ExplicitInterface
    {
        public static void Test()
        {
            SomeType s = new SomeType();
            s.Dispose();

            IDisposable i = s;
            i.Dispose();

            s.ExtensionMethod();
        }
    }

    class SomeType : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("public dispose!");
        }

        void IDisposable.Dispose()
        {
            Console.WriteLine("idisposable dispose!");
        }
    }

    static class SomeTypeExtensionMethods
    {
        public static void ExtensionMethod(this SomeType st)
        {
            Console.WriteLine("This is an extension method of SomeType");
        }
    }
}
