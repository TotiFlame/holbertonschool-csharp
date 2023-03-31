using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int array_length;

        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        for (array_length = array.Length - 1; array_length >= 0; --array_length) {
            if (array_length == 0) {
                Console.Write("{0}", array[array_length]);
            } else {
                Console.Write("{0} ", array[array_length]);
            }
        }
    }
}
