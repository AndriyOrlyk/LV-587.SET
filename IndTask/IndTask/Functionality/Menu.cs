using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IndTask
{
    public class Menu
    {
        private List<Employee> employees = new List<Employee>();
        public void NewPerson(List<Person> people)
        {
            while (true)
            {
                try
                {
                    var person = new Person();
                    person.Input();
                    people.Add(person);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error, please try again - \n" + ex);
                    continue;
                }
                break;
            }
        }
        public void NewEmployee(List<Person> people)
        {
            while (true)
            {
                try
                {
                    var employee = new Employee();
                    employee.Input();
                    people.Add(employee);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error, please try again - \n" + ex);
                    continue;
                }
                break;
            }
        }
        public void GetAge(List<Person> person)
        {
            foreach (var item in person)
            {
                Console.Write($"{item.FirstName} - ");
                Console.WriteLine(item.GetAge());
            }
            Console.WriteLine(new string('=',50));
        }
        public void Output(List<Person> person)
        {
            foreach (var item in person)
            {
                item.OutPut();
            }
            Console.WriteLine(new string('=',50) + "\n");
        }
        public void Elder(List<Person> person)
        {
            foreach (var data in person)
            {
                if(data is Employee)
                {
                    employees.Add((Employee)data);
                }
            }
            foreach (var item in employees)
            {
                if(item.GetAge() > 40 && item.Salary < 1000)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine(new string('=', 50));
        }
        public void SortByFirstAndLastName(List<Person> person)
        {
            var sortingPersonsByFirstALast = person.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);
            foreach (var item in sortingPersonsByFirstALast)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 50));
        }
        public void OutPutInFile(List<Person> person)
        {
            using (StreamWriter file = new StreamWriter(@"D:\SoftServe\Інд\C#\IndTask\IndTask\OutPut.txt"))
            {
                foreach (var items in person)
                {
                    file.WriteLine(items);
                }
            }
            Console.WriteLine("\r\nOutput to File's completed!\r\n");
        }
        public void OutputToFileXML(List<Person> person, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Employee) });
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, person);
            }
            Console.WriteLine("\r\nSerialization's completed!\r\n");
        }
        public void DeserializeXML(string filePath)
        {
            List<Person> people;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Employee) });
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                people = (List<Person>)serializer.Deserialize(fileStream);
            }
            Console.WriteLine("\r\nDeserialization's completed!");
            Console.WriteLine(new string('=', 50));
            Output(people);
        }
    }
}
