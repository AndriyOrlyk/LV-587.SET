using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S={0}, P={1}", a * a, a * 4);
        }
    }
}
