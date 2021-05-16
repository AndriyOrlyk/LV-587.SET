using System;
using System.Collections.Generic;

namespace HW5
{
    class Programmer : IDeveloper
    {
        string language;
        public string Tool
        {
            get => language;
            set => language = value;
        }

        public Programmer() { }
        public Programmer(string language, string tool)
        {
            this.language = language;
            this.Tool = tool;
        }

        public void Create(List<IDeveloper> arr)
        {

            Console.WriteLine("Enter programming language: ");
            language = Console.ReadLine();
            Console.WriteLine("Enter programmer`s tool: ");
            Tool = Console.ReadLine();
            arr.Add(new Programmer(language, Tool));
        }

        public void Destroy(List<IDeveloper> arr)
        {
            arr.RemoveAt(arr.Count - 1);
        }
        public override string ToString()
        {
            return $"Programmer: language: {language}, tool: {Tool}";
        }
    }
}
