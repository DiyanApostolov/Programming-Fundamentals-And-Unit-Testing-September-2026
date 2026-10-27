using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp;

public class NumberFinder
{
    public static string FindSmallestPositive(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            return "List cannot be empty.";

        if (!numbers.Any(n => n > 0))
        {
            return "No positive numbers found.";
        }

        int smallestNumber = int.MaxValue;

        foreach (var number in numbers)
        {
            if(number < smallestNumber && number > 0)
            {
                smallestNumber = number;
            }
        }

        return $"Smallest positive number is: {smallestNumber}";
    }
}
