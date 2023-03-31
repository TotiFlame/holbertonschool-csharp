using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int array_length;

        if (array == null)
        {
            Console.WriteLine();
            return;
        } else if (array.Length == 0) {
            return;
        }
        for (array_length = array.Length - 1; array_length >= 0; --array_length) {
            Console.Write("{0} ", array[array_length]);
        }
    }
}
