using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listShape = new List<Shape>();

            listShape.Add(new Circle("circle1", 12));
            listShape.Add(new Circle("circle2", 2));
            listShape.Add(new Circle("circle3", 1));
            listShape.Add(new Square("squAre1", 2));
            listShape.Add(new Square("square2", 5));
            listShape.Add(new Square("square3", 1));
            Console.WriteLine("\n");
            foreach (var item in listShape)
            {
                item.Print();
            }

            var max = listShape.FirstOrDefault(x => x.Perimeter() == listShape.Max(x => x.Perimeter()));
            Console.WriteLine($"\nThe largest perimeter has shape '{max.name}'");

            var listRangeArea = from shape in listShape where shape.Area() <= 100 & shape.Area() >= 10 select shape;
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(@"D:\SoftServe\Інд\C#\HM\HW8\ShapesRange.txt", false, System.Text.Encoding.Default))
                {
                    foreach (var shape in listShape)
                    {
                        streamWriter.WriteLine(shape.name);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string pattern = @"a";
            Console.WriteLine("\nShapes, which have 'a' in name:");
            foreach (var item in listShape)
            {
                if (Regex.IsMatch(item.name, pattern, RegexOptions.IgnoreCase))
                {
                    item.Print();
                }
            }

            listShape.Sort();
            Console.WriteLine($"\nAfter sorting by Area: ");
            foreach (var item in listShape)
            {
                item.Print();
            }

            Console.WriteLine("\nDeleting shapes with Perimeter < 5:");
            for (int i = listShape.Count - 1; i >= 0; i--)
            {
                if (listShape[i].Perimeter() < 5)
                {
                    listShape.RemoveAt(i);
                }
            }
            foreach (var item in listShape)
            {
                item.Print();
            }

            Person[] people_arr =
            {
                new Developer("b", 1200,"middle"),
                new Teacher("ab", 500 ,"english")
            };

            foreach (var item in people_arr)
            {
                item.Print();
            }

            Console.WriteLine("Enter name for searching:");
            string answer = Console.ReadLine();
            foreach (var item in people_arr)
            {
                if (item.Name == answer)
                {
                    item.Print();
                }
            }
            Console.WriteLine("\nSorted people: ");
            Array.Sort(people_arr);
            foreach (var item in people_arr)
            {
                item.Print();
            }


            Staff[] employees_arr =
            {
                new Developer("b", 1200,"middle"),
                new Teacher("ab", 500 ,"english")
            };
            Console.WriteLine("\nSorted by salary: ");
            Array.Sort(employees_arr);
            foreach (var item in people_arr)
            {
                item.Print();
            }
        }
    }
}
