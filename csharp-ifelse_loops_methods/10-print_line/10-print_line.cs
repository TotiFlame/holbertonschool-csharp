using System;

class Line
{
    public static void PrintLine(int length)
    {
        int i;

        if (length == 0) {
            Console.WriteLine();
            return;
        }

        for(i = 0; i < length; i++) {
            Console.Write("_");
        }
        Console.WriteLine();
    }
}
