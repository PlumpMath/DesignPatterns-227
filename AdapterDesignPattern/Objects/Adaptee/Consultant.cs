using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterDesignPattern.Objects.Adaptee
{
    public class Consultant
    {
        private string Name { get; set; }

        public Consultant (string name)
	    {
            this.Name = name;
	    }

        public void ShowSmile()
        {
            Console.WriteLine("Consultant {0} showed smile!", this.Name);
        }
    }
}
