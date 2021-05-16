using System;

namespace HW8
{
    public class Staff : Person, IComparable<Staff>
    {
        protected int salary;
        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: {1}",
                Name, this.salary);
        }
        public int CompareTo(Staff other)
        {
            return this.salary.CompareTo(other.salary);
        }
    }
}
