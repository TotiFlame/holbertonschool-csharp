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
        int i;

        for (i = 0; i < size; i++)
        {
            new_array[i] = i;
            if (i == size - 1) {
                Console.Write("{0}", new_array[i]);
            } else {
                Console.Write("{0} ", new_array[i]);
            }
        }
        Console.WriteLine();
        return(new_array);
    }
}
