using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatternCarExample.Objects
{
    public class CarElementPrintVisitor : ICarElementVisitor
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Visiting {0} wheel", wheel.Name);
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine("Visiting Engine");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Visiting Body");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Visiting Car");
        }
    }
}
