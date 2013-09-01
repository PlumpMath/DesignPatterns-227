using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorDemo.Objects.Decorator;
using DecoratorDemo.Objects.Component;

namespace DecoratorDemo.Objects.ConcreteDecorators
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza)
            : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.25;
        }

    }
}
