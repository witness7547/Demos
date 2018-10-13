using HostSDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly assem = Assembly.LoadFile(@"C:\Users\fmisx\Documents\Visual Studio 2015\Projects\Demos\AddInTypes\bin\Debug\AddInTypes.dll");

            string addInDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            var addInAssemblies = Directory.EnumerateFiles(addInDir, "*.dll");

            var addInTypes = from file in addInAssemblies
                             let assembly = Assembly.LoadFile(file)
                             from t in assembly.ExportedTypes
                             where t.IsClass && typeof(IAddIn).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo())
                             select t;

            foreach (Type t in addInTypes)
            {
                IAddIn ai = (IAddIn)Activator.CreateInstance(t);
                Console.WriteLine(ai.DoSomeThing(5));
            }

            Console.ReadLine();
        }
    }
}
