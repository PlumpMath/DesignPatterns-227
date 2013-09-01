using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterDesignPattern.Objects.Adapter;
using AdapterDesignPattern.Objects.ConcreteAdapter;

namespace AdapterDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            var empoyees = new List<IEmployee>(){
                new Employee("Ram"),
                new Employee("Sam"),
                new ConsultantToEmployeeAdapter("Kris")
            };

            foreach (var e in empoyees)
            {
                e.ShowHappyness();
            }
            Console.ReadLine();
        }
    }
}
