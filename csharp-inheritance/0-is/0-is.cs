using System;

class Obj
{
    /// <summary> IsOfTypeInt Method </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        return false;
    }
}
