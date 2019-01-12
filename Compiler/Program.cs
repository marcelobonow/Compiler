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

            elementsToSum.Add(new Element(null, null, 5));
            elementsToSum.Add(new Element(null, null, 10));
            elementsToSum.Add(new Element(null, null, 3));

            var head = new Element(elementsToSum, new Operation());

            tree.SetHead(head);
            Console.WriteLine("Testando soma");
            Console.Write("5 + 10 + 3 = " + tree.EvaluateTree());
            Console.ReadKey();
        }
    }
}