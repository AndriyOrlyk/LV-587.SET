using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();

            myDict = File.ReadAllLines(@"D:\SoftServe\Інд\C#\HM\HM7\phones.txt")
                                       .Select(x => x.Split('-'))
                                       .ToDictionary(x => x[0], x => x[1]);

            var phoneNumbers = myDict.Values.ToList();
            var phoneNames = myDict.Keys.ToList();
            List<string> newOnlyPhoneNumbers = new List<String>();

            using (StreamWriter file = new StreamWriter(@"D:\SoftServe\Інд\C#\HM\HM7\Phoness.txt"))
                foreach (var entry in myDict)
                {
                    file.WriteLine($"{entry.Value}");
                }

            Console.WriteLine("Enter id of the user u wanna to find: ");
            var userSearch = Console.ReadLine();
            var foundUserPhone = myDict.FirstOrDefault(x => x.Key == userSearch).Value;
            if (foundUserPhone == null)
            {
                Console.WriteLine("No such user!");
            }
            else
            {
                Console.WriteLine($"The number of  {userSearch} is: {foundUserPhone}");
            }

            List<string> listToChange = new List<string>();
            foreach (var tempKey in myDict.Keys)
            {
                if (myDict[tempKey].StartsWith("80"))
                {
                    listToChange.Add(tempKey);
                }
            }

            foreach (var item in listToChange)
            {
                myDict[item] = "+3" + myDict[item];
            }

            using (StreamWriter file = new StreamWriter(@"D:\SoftServe\Інд\C#\HM\HM7\New.txt"))
                foreach (var entry in myDict)
                {
                    file.WriteLine($"{entry.Key}-{entry.Value}");
                }
        }
    }
}
