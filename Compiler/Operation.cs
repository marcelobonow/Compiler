///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    class Operation
    {
        public virtual float DoOperation(float number1, float number2) => throw new NotImplementedException();
        public virtual string GetSymbol() => throw new NotImplementedException();
    }
    class Sum : Operation
    {
        public override float DoOperation(float number1, float number2) => number1 + number2;
        public override string GetSymbol() => "+";
    }
    class Subtraction : Operation
    {
        public override float DoOperation(float number1, float number2) => number1 - number2;
        public override string GetSymbol() => "-";
    }
    class Multiply : Operation
    {
        public override float DoOperation(float number1, float number2) => number1 * number2;
        public override string GetSymbol() => "*";
    }
    class Divide : Operation
    {
        public override float DoOperation(float number1, float number2) => number1 / number2;
        public override string GetSymbol() => "/";
    }
}
