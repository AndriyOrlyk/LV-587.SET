using System;
using System.Collections.Generic;

namespace IndTask
{
    public class View
    {
        private const string XMLFilePath = @"D:\SoftServe\Інд\C#\IndTask\IndTask\OutPut.xml";
        public void Views()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person(1, "Andrew", "Orlyk", new DateTime(1999, 12, 03)));
            persons.Add(new Person(2, "Kolodiy", "Barilyak", new DateTime(2003, 06, 16)));
            persons.Add(new Person(3, "Yukhim", "Clever", new DateTime(1992, 09, 17)));
            persons.Add(new Person(4, "Yaroslav", "Savkiv", new DateTime(1995, 12, 01)));
            persons.Add(new Person(5, "Odinets", "Trutovsky", new DateTime(1990, 03, 10)));

            DateTime firstDate = new DateTime(1960, 03, 08);
            DateTime secondDate = new DateTime(1970, 06, 25);
            DateTime thirdDate = new DateTime(2021, 06, 25);
            persons.Add(new Employee(8, "Fedor", "Zaluzhny", firstDate, thirdDate, 800));
            persons.Add(new Employee(2, "Adrian", "Paskevich", secondDate, thirdDate, 1000));

            while (true)
            {
                Console.WriteLine("You can choose any options: \n" +
                    "1 - Output data,\n" +
                    "2 - Create new Person,\n" +
                    "3 - Create new Employee,\n" +
                    "4 - Sort by FirstName and LastName,\n" +
                    "5 - Employees elder 40 years and have less than 1000 salary,\n" +
                    "6 - Get age people,\n" +
                    "7 - Output to File,\n" +
                    "8 - Serialize data,\n" +
                    "9 - Deserialize data,\n" +
                    "0 - Exit\r\n");
                Console.WriteLine(new string('=', 50));

                Console.Write("Enter your choice: ");
                var userChoice = Convert.ToInt32(Console.ReadLine());
                var menu = new Menu();

                switch (userChoice)
                {
                    case 1:
                        menu.Output(persons);
                        break;
                    case 2:
                        menu.NewPerson(persons);
                        break;
                    case 3:
                        menu.NewEmployee(persons);
                        break;
                    case 4:
                        menu.SortByFirstAndLastName(persons);
                        break;
                    case 5:
                        menu.Elder(persons);
                        break;
                    case 6:
                        menu.GetAge(persons);
                        break;
                    case 7:
                        menu.OutPutInFile(persons);
                        break;
                    case 8:
                        menu.OutputToFileXML(persons, XMLFilePath);
                        break;
                    case 9:
                        menu.DeserializeXML(XMLFilePath);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Try again, uknown operation!");
                        break;
                }
            }
        }
    }
}
