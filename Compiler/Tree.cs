using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Tree
{
    public Element head;

    public void SetHead(Element element) => head = element;
    public void Evaluate()
    {
        var leftChild = head.GetLeftChild();
        var rightChild = head.GetRightChild();

        if(head.GetValue() is Operation headOperation && leftChild.GetValue() is Number leftNumber && rightChild.GetValue() is Number rightNumber)
        {

            Console.Write($"{leftChild.GetValue()} {headOperation.GetAsString()} {rightChild.GetValue()} = {headOperation.DoOperation(leftNumber, rightNumber)}");
        }
    }
}

internal class Element
{
    private Element leftChild, rightChild;
    private Symbol value;

    public Element(Symbol value, Element leftChild = null, Element rightChild = null)
    {
        this.leftChild = leftChild;
        this.rightChild = rightChild;
        this.value = value;
    }
    public Element(float value)
    {
        this.leftChild = null;
        this.rightChild = null;
        this.value = new Number(value);
    }
    public Symbol GetValue() => value;
    public Element GetLeftChild() => leftChild;
    public Element GetRightChild() => rightChild;
}
