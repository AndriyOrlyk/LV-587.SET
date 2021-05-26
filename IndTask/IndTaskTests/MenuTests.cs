using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndTask;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace IndTask.Tests
{
    [TestClass()]
    public class MenuTests
    {
        [TestMethod()]
        public void NewEmployeeTest()
        {
            DateTime firstDate = new DateTime(1960, 03, 08);
            DateTime secondDate = new DateTime(2021, 06, 25);
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(8, "Fedor", "Zaluzhny", firstDate, secondDate, 800));

            var beforeEmployee = employees.Count();

            employees.Add(new Employee(9, "Adrian", "Paskevich", firstDate, secondDate, 1000));

            var afterEmployee = employees.Count();

            Assert.AreEqual(beforeEmployee, afterEmployee - 1);
        }

        [TestMethod()]
        public void NewPersonTest()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "Andrew", "Orlyk", new DateTime(1999, 12, 03)));
            persons.Add(new Person(2, "Kolodiy", "Barilyak", new DateTime(2003, 06, 16)));

            var beforePersons = persons.Count();

            persons.Add(new Person(3, "Yukhim", "Clever", new DateTime(1992, 09, 17)));
            persons.Add(new Person(4, "Yaroslav", "Savkiv", new DateTime(1995, 12, 01)));
            persons.Add(new Person(5, "Odinets", "Trutovsky", new DateTime(1990, 03, 10)));

            var afterPersons = persons.Count();

            Assert.AreEqual(beforePersons, afterPersons - 3);
        }
        [TestMethod()]
        public void OutPutInFileTest()
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

            string path = @"D:\SoftServe\Інд\C#\IndTask\IndTask\OutPut.txt";
            
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (var items in persons)
                {
                    streamWriter.WriteLine(items);
                }
            }

            StreamReader streamReader;
            using (streamReader = new StreamReader(path))
            {
                streamReader.ReadToEnd();
            }
            Assert.IsNotNull(streamReader);

        }
    }
}