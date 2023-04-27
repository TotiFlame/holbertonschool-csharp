using System;
using System.Reflection;

class Obj
{
    /// <summary> Method that prints properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        PropertyInfo[] properties = myObj.GetType().GetProperties();
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine(prop.Name);
        }
        MethodInfo[] methods = myObj.GetType().GetMethods();
        foreach (MethodInfo meth in methods)
        {
            Console.WriteLine(meth.Name);
        }
    }
}
