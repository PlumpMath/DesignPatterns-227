using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorDemo.Objects.Component;

namespace DecoratorDemo.Objects.ConcreteComponents
{
    public class MediumPizza : Pizza
    {

        public MediumPizza()
        {
            Description = "Medium Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 6.00;
        }
    }
}
