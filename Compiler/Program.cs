using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainClass
{
    private static void Main(string[] args)
    {
        var number1 = new Element(5);
        var number2 = new Element(10);
        var operation = new Element(new Sum(), number1, number2);

        var tree = new Tree();
        tree.SetHead(operation);
        tree.Evaluate();

        Console.ReadKey();
    }
}
