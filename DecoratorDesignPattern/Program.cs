using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorDemo.Objects.ConcreteComponents;
using DecoratorDemo.Objects.Component;
using DecoratorDemo.Objects.ConcreteDecorators;
using DecoratorDemo.Objects.Decorator;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new SmallPizza();
            //largePizza = new Cheese(largePizza);
            //largePizza = new Ham(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Cheese(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
