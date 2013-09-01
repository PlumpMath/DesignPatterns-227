using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositeDesignPattern.Objects.Component;

namespace CompositeDesignPattern.Objects.Leaf
{
    public class LeafNode : INode
    {
        private string Name;
        public LeafNode(string name)
        {
            this.Name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine("{0}{1}", new String('-', depth), Name);
        }
    }
}
