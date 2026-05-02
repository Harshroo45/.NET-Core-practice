using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 6, 6 };

        // LINQ query syntax to get unique values
        var uniqueNumbers = (from n in numbers
                             select n).Distinct();

        Console.WriteLine("Unique Numbers:");

        foreach (var num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }
    }
}