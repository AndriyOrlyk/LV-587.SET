using System;

namespace HW8
{
    public class Circle : Shape, IComparable<Circle>
    {
        protected double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public Circle()
        {
            name = "name";
            Radius = 0;
        }
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public override double Perimeter()
        {
            return (2 * Math.PI * Radius);
        }
        public override void Print()
        {
            Console.WriteLine($"name: {name}, radius: {Radius}, area: {Area()}, perimeter: {Perimeter()}");
        }

        public override void Input()
        {
            Console.WriteLine("Enter name of circle");
            name = Console.ReadLine();
            Console.WriteLine("Enter radius:");
            Radius = double.Parse(Console.ReadLine());
        }
        public int CompareTo(Circle other)
        {
            return this.Area().CompareTo(other.Area());
        }

    }


}
