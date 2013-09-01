using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorDemo.Objects.Decorator;
using DecoratorDemo.Objects.Component;

namespace DecoratorDemo.Objects.ConcreteDecorators
{
    public class Peppers : PizzaDecorator
    {
        public Peppers(Pizza pizza)
            : base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}
