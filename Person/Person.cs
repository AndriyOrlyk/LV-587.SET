using System;

namespace Person
{
    class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name => name;
        public DateTime BirthYear => birthYear;
        private int age { get; set; }
        public Person() { }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = (DateTime)birthYear;
        }
        public void Input()
        {
            Console.Write("Enter the name of a person: ");
            name = Console.ReadLine();
            Console.Write("Enter the date of birth of the person: ");
            birthYear = Convert.ToDateTime(Console.ReadLine());
        }
        public void Age()
        {
            age = DateTime.Now.Year - birthYear.Year;
        }

        public void ChangeName()
        {
            if (age < 16)
            {
                name = "Very Young";
            }
        }
        public void Output() => Console.WriteLine(ToString());
        public static bool operator ==(Person a, Person b)
        {
            return (a.name == b.name);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !(a.name == b.name);
        }
        public override string ToString()
        {
            return "Name of a person is: " + name + " " + "The age is:" + age;
        }

    }
}
