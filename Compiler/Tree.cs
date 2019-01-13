using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    class Tree
    {
        private Element headElement;

        public float EvaluateTree()
        {
            float value = headElement.Evaluate();
            Console.Write("=" + value);
            return value;
        }
        public void SetHead(Element head) => headElement = head;
    }
    class Element
    {
        private List<Element> childs;
        private float numberValue;
        private Operation operationValue;

        public Element(List<Element> childs, Operation operationValue, float numberValue = 0)
        {
            this.childs = childs;
            this.operationValue = operationValue;
            this.numberValue = numberValue;
        }
        public void AddChild(Element child)
        {
            if(childs == null)
                childs = new List<Element>();
            childs.Add(child);
        }
        public void AddChild(List<Element> child)
        {
            if(childs == null)
                childs = new List<Element>();
            childs.AddRange(child);
        }

        public float Evaluate()
        {
            if(operationValue != null)
            {
                float value = childs[0].Evaluate();
                Console.Write(operationValue.GetSymbol());
                for(int i = 1; i < childs.Count; i++)
                {
                    var child = childs[i];
                    value = operationValue.DoOperation(value, child.Evaluate());
                    if(i != childs.Count - 1)
                        Console.Write(operationValue.GetSymbol());
                }
                return value;
            }
            else
            {
                Console.Write(numberValue);
                return numberValue;
            }

        }
    }
}
