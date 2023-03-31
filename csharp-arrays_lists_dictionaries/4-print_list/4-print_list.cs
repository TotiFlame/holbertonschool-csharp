using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return(null);
        }

        List<int> numbers = new List<int>();
        while (i < size) {
        {
            numbers.Add(i);
            i++;
        }
        Console.WriteLine("{0}", numbers);
        return(numbers);
        }
    }
}
