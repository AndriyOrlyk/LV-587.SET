using System;

namespace HW8
{
    public abstract class Shape : IComparable<Shape>
    {
        public string name;
        public string Name { get; set; }

        public Shape()
        {
            name = "name";
        }
        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public abstract void Print();

        public abstract void Input();
        public int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }

    }
}
