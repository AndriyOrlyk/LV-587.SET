using System;
using System.Collections.Generic;

namespace HW5
{
    class Builder : IDeveloper
    {
        private string tool;
        public string Tool
        {
            get => tool;
            set => tool = value;
        }

        public Builder() { }
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create(List<IDeveloper> arr)
        {

            Console.WriteLine("Enter tool: ");
            Tool = Console.ReadLine();
            arr.Add(new Builder(tool));

        }

        public void Destroy(List<IDeveloper> arr)
        {
            arr.RemoveAt(arr.Count - 1);
        }

        public override string ToString()
        {
            return $"Builder: tool: {Tool}";
        }
    }
}
