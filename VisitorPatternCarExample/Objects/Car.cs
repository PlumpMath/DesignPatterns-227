using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatternCarExample.Objects
{
    public class Car : ICarElement
    {
        private List<ICarElement> elements;

        public Car()
        {
            this.elements = new List<ICarElement>(){
                new Wheel("Front left"),
                new Wheel("Front right"),
                new Wheel("back left"),
                new Wheel("back right"),
                new Body(),
                new Engine()
            };
        }

        public void Accept(ICarElementVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}
