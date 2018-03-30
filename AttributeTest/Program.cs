using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//[assembly: AssemblyTitle("My Assembly")]

namespace AttributeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Example.Add(1, 2));
        }
    }

    public class Example
    {
        // Specify attributes between square brackets in C#.
        // This attribute is applied only to the Add method.
        [Obsolete("Will be removed in next version."/*, true*/)]
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
