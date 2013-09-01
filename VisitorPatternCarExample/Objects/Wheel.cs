using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatternCarExample.Objects
{
    public class Wheel : ICarElement
    {
        public string Name { get; set; }

        public Wheel(string name)
        {
            this.Name = name;
        }

        public void Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
