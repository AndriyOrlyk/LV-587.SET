using System;

namespace HW8
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }
        virtual public void Print()
        {
            Console.WriteLine($"name: {Name}");
        }

    }
}
