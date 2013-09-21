using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.Objects;

namespace FactoryMethod
{
    class Client
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                Product product = creator.FactoryMethod();

                Console.WriteLine("created {0}", product.GetType().Name);
            }

            Console.Read();
        }
    }
}
