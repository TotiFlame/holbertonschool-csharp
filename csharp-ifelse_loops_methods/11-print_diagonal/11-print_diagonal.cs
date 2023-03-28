using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if(length == 0 || length < 0) {
            Console.WriteLine();
            return;
        }

        int j, i;
        for (i = 0; i < length; i++)
        {
            Console.WriteLine("\\");
            for (j = 0; j <= i; j++)
            {
                Console.Write(" ");
                // Console.Write("spaces: {0}", j);
            }
        }
        Console.WriteLine();
    }
}
