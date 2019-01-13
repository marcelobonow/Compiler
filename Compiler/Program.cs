using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    public class MainClass
    {
        private static void Main(string[] args)
        {
            var tree = new Tree();
            var elementsToSum = new List<Element>();
            var elementsToDivide = new List<Element>();

            elementsToSum.Add(new Element(null, null, 5));
            elementsToSum.Add(new Element(null, null, 10));
            elementsToSum.Add(new Element(null, null, 3));

            elementsToDivide.Add(new Element(null, null, 2));
            elementsToDivide.Add(new Element(null, null, 0.5f));


            var sum = new Element(elementsToSum, new Sum());
            var head = new Element(new List<Element> { sum }, new Divide());

            head.AddChild(elementsToDivide);

            tree.SetHead(head);
            Console.WriteLine("Testando arvore");
            tree.EvaluateTree();
            //Console.Write("5 + 10 + 3 = " + tree.EvaluateTree());
            Console.ReadKey();
        }
    }
}