using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return(null);
        }

        int[] new_array = new int[size];
        int i, j;

        for (i = 0; i < size; i++)
        {
            new_array[i] = i;
        }

        for (j = 0; j < size; j++)
        {
            Console.Write("{0} ", new_array[j]);
        }
        Console.WriteLine();
        return(new_array);
    }
}
