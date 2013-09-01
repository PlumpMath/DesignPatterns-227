using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorDemo.Objects.Component
{
    public abstract class Pizza
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract double CalculateCost();
    }
}
