using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 0;
            //var o = 0;
            //var i = 0;
            //var e = 0;
            //Console.WriteLine("Enter a word: ");
            //string str = Convert.ToString(Console.ReadLine());
            //foreach (var item in str)
            //{
            //    if (item == 'a')
            //        a++;
            //    else if(item == 'o')
            //        o++;
            //    else if(item == 'i')
            //        i++;
            //    else if(item == 'e')
            //        e++;
            //}
            //Console.WriteLine($"a = {a}\no = {o} \ni = {i} \ne = {e}");

            Console.WriteLine(new string('=',50));


            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            if(month > 0 && month <= 12)
            {
                int daysinmon = DateTime.DaysInMonth(year, month);
                Console.WriteLine(daysinmon);
            }
            else
            {
                Console.WriteLine("There's no such month");
            }
        }
    }
}
