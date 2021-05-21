using System;

namespace HW8
{
    public class Square : Shape, IComparable<Square>
    {
        protected double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public Square()
        {
            Side = 0;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
        public override void Print()
        {
            Console.WriteLine($"name: {name}, side: {Side}, area: {Area()}, perimeter: {Perimeter()}");
        }

        public override void Input()
        {
            Console.WriteLine("Enter name of  square");
            name = Console.ReadLine();
            Console.WriteLine("Enter side:");
            Side = double.Parse(Console.ReadLine());

        }
        public int CompareTo(Square other)
        {
            return this.Area().CompareTo(other.Area());
        }


    }

}
