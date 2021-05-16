using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCircleLengthAreaVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("L={0}, S={1}, V={2}", 2 * Math.PI * r, Math.PI * r * r, (4 / 3) * Math.PI * r * r * r);
        }
    }
}
