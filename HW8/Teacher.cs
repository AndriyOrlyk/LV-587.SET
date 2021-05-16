using System;

namespace HW8
{
    public class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine($"Client \nname: {Name} Salary: {salary}  Subject: {this.subject}");
        }

    }
}
