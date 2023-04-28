using System;
using System.Reflection;

class Obj
{
    /// <summary> Method that prints properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        PropertyInfo[] properties = myObj.GetType().GetProperties();
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        MethodInfo[] methods = myObj.GetType().GetMethods();
        foreach (MethodInfo meth in methods)
        {
            Console.WriteLine(meth.Name);
        }
    }
}
