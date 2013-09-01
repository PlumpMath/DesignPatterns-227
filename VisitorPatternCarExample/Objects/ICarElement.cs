using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPatternCarExample.Objects
{
    public interface ICarElement
    {
        void Accept(ICarElementVisitor visitor);
    }
}
