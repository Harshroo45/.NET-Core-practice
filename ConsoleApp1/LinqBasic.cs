
using System;
using System.Linq;
using System.Collections.Generic;

internal class LinqBasic
{
    public static void Run()
    {
        int[] arr = { 1, 2, 3, 4, 5, 7, 8};
        var sum = arr.Aggregate((a, b) => a + b);

        Console.WriteLine(sum);
    }
}