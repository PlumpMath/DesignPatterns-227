using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterDesignPattern.Objects.Adapter
{
    public class Employee: IEmployee
    {
        private string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }

        public void ShowHappyness()
        {
            Console.WriteLine("Empoyee {0} showed happyness!", this.Name);
        }
    }
}
