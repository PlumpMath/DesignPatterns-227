using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatternCarExample.Objects
{
    public class CarElementDoVisitor : ICarElementVisitor
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Kicking {0} wheel", wheel.Name);
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine("starting my Engine");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("moving my Body");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Starting my Car");
        }
    }
}
