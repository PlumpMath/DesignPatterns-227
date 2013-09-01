using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Objects.Facade;

namespace FacadePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Computer facade = new Computer();
            facade.start();

            facade.Shutdown();
        }
    }
}
