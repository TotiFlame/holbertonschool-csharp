using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {0};

        PrintArray(array);
        Array.ReplaceElement(array, 1, 98);
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        int i;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }
        
        Console.WriteLine();
    }
}