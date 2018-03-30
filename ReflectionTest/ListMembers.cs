// This program lists all the public constructors
// of the System.String class.
using System;
using System.Reflection;

class ListMembers
{
    public static void Main()
    {
        //Type t = typeof(System.String);
        //Console.WriteLine("Listing all the public constructors of the {0} type", t);
        //// Constructors.
        //ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        //Console.WriteLine("//Constructors");
        //PrintMembers(ci);


        //string s = "abcde";
        //Console.WriteLine(s[5]);

        // Gets the mscorlib assembly in which the object is defined.
        //Assembly a = typeof(object).Module.Assembly;


        // Loads an assembly using its file name.
        Assembly a = Assembly.LoadFrom("ReflectionTest.exe");
        // Gets the type names from the assembly.
        Type[] types2 = a.GetTypes();
        foreach (Type t in types2)
        {
            Console.WriteLine(t.FullName);
        }

        Console.ReadLine();
    }

    public static void PrintMembers(MemberInfo[] ms)
    {
        foreach (MemberInfo m in ms)
        {
            Console.WriteLine("{0}{1}", "     ", m);
        }
        Console.WriteLine();
    }
}

class MyClass1
{

}

class MyClass2
{

}