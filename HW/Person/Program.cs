using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Andrew", DateTime.Parse("03.12.1999"));
            person1.Age();
            person1.Output();

            var people = new Person[6];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                people[i].Input();
                people[i].Age();
            }
            Console.WriteLine();
            Console.WriteLine("Change name of people whose age is under 16");
            for (int i = 0; i < people.Length; i++)
            {
                people[i].ChangeName();
                Console.WriteLine(people[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine("People with the same names");
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Person{i + 1} and person {j + 1} have the same name");
                    }
                }
            }
        }
    }
}
