using System;

class Character
{
    public static bool IsLower(char c)
    {
        int ch = Convert.ToInt32(c);
        if (ch > 96 && ch < 123) {
            return (true);
        } else
            return (false);
    }
}