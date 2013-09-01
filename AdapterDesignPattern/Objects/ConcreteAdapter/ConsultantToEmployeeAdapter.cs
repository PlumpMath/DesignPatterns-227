using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterDesignPattern.Objects.Adapter;
using AdapterDesignPattern.Objects.Adaptee;

namespace AdapterDesignPattern.Objects.ConcreteAdapter
{
    public class ConsultantToEmployeeAdapter : Consultant, IEmployee
    {
        public ConsultantToEmployeeAdapter(string name)
            : base(name)
        {
        }
        public void ShowHappyness()
        {
            base.ShowSmile();
        }
    }
}
