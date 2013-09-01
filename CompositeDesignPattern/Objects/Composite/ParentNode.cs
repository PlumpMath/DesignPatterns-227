using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositeDesignPattern.Objects.Component;

namespace CompositeDesignPattern.Objects.Composite
{
    public class ParentNode : INode
    {
        private string Name;

        public ParentNode(string name)
        {
            this.Name = name;
            this.Children = new List<INode>();
        }

        public void AddChild(INode node)
        {
            Children.Add(node);
        }

        public void RemoveChild(INode node)
        {
            Children.Remove(node);
        }

        public IList<INode> Children { get; private set; }

        public void Display(int depth)
        {
            Console.WriteLine("{0}{1}", new String('-', depth), Name);
            foreach (var item in Children)
            {
                item.Display(depth +2);
            }
        }
    }
}
