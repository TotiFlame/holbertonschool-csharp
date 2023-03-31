using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return(null);
        }
        if (size == 0) {
            Console.WriteLine();
        }

        int i = 0, j;
        List<int> numbers = new List<int>();
        while (i < size)
        {
            numbers.Add(i);
            i++;
        }
        for (j = 0; j < size; j++)
        {
            if (j == size - 1) {
                Console.Write(numbers[j] + "\n");
            } else
            {
                Console.Write(numbers[j] + " ");
            }
        }
        return numbers;
    }
}
