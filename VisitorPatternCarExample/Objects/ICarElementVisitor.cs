using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatternCarExample.Objects
{
    public interface ICarElementVisitor
    {
        void Visit(Wheel wheel);
        void Visit(Engine engine);
        void Visit(Body body);
        void Visit(Car car);
    }
}
