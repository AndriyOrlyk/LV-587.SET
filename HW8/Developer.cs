using System;

namespace HW8
{
    public class Developer : Staff
    {
        private string level;

        public Developer(string name, int salary, string level) : base(name, salary)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"Client \nname: {Name} Salary: {salary}  Level: {level}");
        }

    }
}
