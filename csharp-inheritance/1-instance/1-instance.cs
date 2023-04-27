using System;

class Obj
{
    /// <summary> IsInstanceOfArray Method </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return typeof(Array).IsInstanceOfType(obj);
    }
}
