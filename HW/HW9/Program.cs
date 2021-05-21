using System;
using System.Collections.Generic;
using System.Linq;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for (int i = -1; i < 9; i++)
            {
                nums.Add(i);
                Console.Write($"{i}, ");
            }

            Console.WriteLine("\nNegative numbers: ");
            var underZero = string.Join(", ", nums.Where(item => item < 0));
            Console.WriteLine($"{underZero}");

            Console.WriteLine("Positive numbers: ");
            var aboveZero = string.Join(", ", nums.Where(item => item >= 0));
            Console.WriteLine($"{aboveZero}");

            int max = nums.Max();
            int min = nums.Min();
            Console.WriteLine($"Largest number: {max}, Smallest: {min}");

            double average = nums.Average();
            Console.WriteLine($"Average: {average}");
            var underAverage = string.Join(", ", nums.Where(item => item < average));
            Console.WriteLine($"Integers are above average: {underAverage}");

            Console.WriteLine($"Largest one: {underAverage.Max()}");

            var orderedNumbers = string.Join(",", nums.OrderBy(nums => nums));
            Console.WriteLine($"Ordered by ASC: {orderedNumbers}");
        }
    }
}
