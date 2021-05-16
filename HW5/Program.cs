using System;
using System.Collections.Generic;
using System.Linq;

namespace HW5
{
    class Program
    {
        static void Output(List<IDeveloper> arr)
        {
            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
        }
        static void Main(string[] args)
        {
            Programmer programer = new Programmer();
            Builder builder = new Builder();
            List<IDeveloper> arrDevelopers = new List<IDeveloper>();
            Console.WriteLine("Adding 2 programmers: ");
            for (int i = 0; i < 2; i++)
            {
                programer.Create(arrDevelopers);
            }
            Console.WriteLine("Adding 2 builders: ");
            for (int i = 0; i < 2; i++)
            {
                builder.Create(arrDevelopers);
            }
            foreach (var item in arrDevelopers)
            {
                Console.WriteLine(item);

            }
            programer.Destroy(arrDevelopers);
            Output(arrDevelopers);
            builder.Destroy(arrDevelopers);
            Console.WriteLine("After Destroy is called: ");
            Output(arrDevelopers);

            var sortedList = string.Join(",", arrDevelopers.OrderBy(item => item.Tool));
            Console.WriteLine($"Ordered by ASC: {sortedList}\n");
        }
    }
}
