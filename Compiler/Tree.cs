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
            return headElement.Evaluate();
        }
        public void SetHead(Element head)
        {
            headElement = head;
        }
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

        public float Evaluate()
        {
            if(operationValue != null)
            {
                float value = 0;
                foreach(var child in childs)
                    value += child.Evaluate();
                return value;
            }
            else
                return numberValue;
        }
    }
}
