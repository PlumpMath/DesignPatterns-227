using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BridgeDesignPattern.Objects.Abstraction;
using BridgeDesignPattern.Objects.RefinedAbstraction;
using BridgeDesignPattern.Objects.ConcreteImplementor;

namespace BridgeDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new CircleShape(1,2, 3, new DrawingApiOne()),
                new CircleShape(5,7, 11, new DrawingApiTwo())
            };

            foreach (var item in shapes)
            {
                item.ResizeByPercentage(2.5d);
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}
