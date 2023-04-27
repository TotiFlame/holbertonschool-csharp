using System;

class Obj
{
    /// <summary> Method that return true if the derivedType is subclass of baseType.</summary> 
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
