using System;

namespace IndTask
{
    public class Employee : Person
    {
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }
        public Employee(int taxNumber, string firstName, string lastName, DateTime birthday, DateTime employmentDate, double salary) : base(taxNumber, firstName, lastName, birthday)
        {
            EmploymentDate = employmentDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + ($" EmploymentDate: {EmploymentDate.ToString("dd/MM/yyyy")}, Salary: {Salary}");
        }
        public override void OutPut()
        {
            Console.WriteLine(this);
        }
        public override void Input()
        {
            base.Input();
            
            Console.Write("Please, enter YearOfEntry of format year/month/day : ");
            EmploymentDate = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Please, enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(new string('=', 50));
        }
    }
}
