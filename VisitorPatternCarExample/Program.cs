using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisitorPatternCarExample.Objects;

namespace VisitorPatternCarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarElement car = new Car();
            car.Accept(new CarElementPrintVisitor());
            car.Accept(new CarElementDoVisitor());

            Console.ReadLine();
        }
    }
}
