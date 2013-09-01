using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositeDesignPattern.Objects.Composite;
using CompositeDesignPattern.Objects.Leaf;

namespace CompositeDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            ParentNode root = new ParentNode("root");
            root.AddChild(new LeafNode("Leaf L"));

            var p = new ParentNode("Parent P");
            p.AddChild(new LeafNode("Leaf L1"));
            p.AddChild(new LeafNode("Leaf L2"));
            
            root.AddChild(p);
            root.AddChild(new LeafNode("Leaf RL1"));

            root.Display(1);

            Console.ReadLine();
        }
    }
}
