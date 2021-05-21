using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsUrNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, your name is {0} and you are {1}", name, age);
        }
    }
}
