using System;

namespace IndTask
{
    public class Person
    {
        public int TaxNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person()
        {

        }
        public Person(int taxNumber, string firstName, string lastName, DateTime birthday)
        {
            TaxNumber = taxNumber;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthday;
        }
        public override string ToString()
        {
            return ($"TaxNumber: {TaxNumber}, FirstName: {FirstName}, LastName: {LastName}, BirthDate: {BirthDate.ToString("dd/MM/yyyy")}");
        }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        public virtual void OutPut()
        {
            Console.WriteLine(this);

        }
        public virtual void Input()
        {
            Console.Write("Please, enter TaxNumber: ");
            TaxNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter FirstName: ");
            FirstName = Console.ReadLine();
            
            Console.Write("Enter LastName: ");
            LastName = Console.ReadLine();
            
            Console.Write("Please, enter birthdate of format Year/Month/Day: ");
            BirthDate = DateTime.Parse(Console.ReadLine());
        }
    }
}
