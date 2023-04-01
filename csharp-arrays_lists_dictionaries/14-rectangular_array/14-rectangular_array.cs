using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] result = { {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 1, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0} };
        int arr_length = result.Length;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++) {
                if (j == 4)
                {
                    Console.Write(result[i,j]);
                    continue;
                }
                Console.Write(result[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}

