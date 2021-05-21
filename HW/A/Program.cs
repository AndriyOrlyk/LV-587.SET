using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_B_C_D
{
    
    class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format($"Name: {name} \nMark: {mark} \nAge: {age}");
            }
        };
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
        }
        static void GetNameOfError(int error)
        {
            switch (error)
            {
                case 400:
                    Console.WriteLine(HTTPError.Bad_Request);
                    break;
                case 401:
                    Console.WriteLine(HTTPError.Unauthorized);
                    break;

                case 402:
                    Console.WriteLine(HTTPError.Payment_Required);
                    break;

                case 403:
                    Console.WriteLine(HTTPError.Forbidden);
                    break;
                


            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (l >= -5 && l <= 5)
            {
                Console.WriteLine($"Number {l} belongs to the range [-5,5]");
            }
            else
                Console.WriteLine($"Number {l} does not belongs to the range [-5,5]");
            if (m >= -5 && m <= 5)
            {
                Console.WriteLine($"Number {m} belongs to the range [-5,5]");
            }
            else
                Console.WriteLine($"Number {m} does not belongs to the range [-5,5]");
            if (n >= -5 && n <= 5)
            {
                Console.WriteLine($"Number {n} belongs to the range [-5,5]");
            }
            else
                Console.WriteLine($"Number {n} does not belongs to the range [-5,5]");


            //Task B

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Largest of three: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c)));

            //Task C

            int error = Convert.ToInt32(Console.ReadLine());
            GetNameOfError(error);


            //Task D

            Dog myDog;
            myDog.name = "Dog";
            myDog.mark = "Dog1";
            myDog.age = 2;

            Console.WriteLine(myDog);
            Console.ReadLine();
        }
    }
}
