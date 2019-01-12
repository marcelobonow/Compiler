﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    class Operation
    {
        public virtual float DoOperation(float number1, float number2)
        {
            return number1 + number2;
        }
    }
    class Sum : Operation
    {
        public override float DoOperation(float number1, float number2)
        {
            return number1 + number2;
        }
    }
    class Subtraction : Operation
    {
        public override float DoOperation(float number1, float number2)
        {
            return number1 - number2;
        }
    }
    class Multiply : Operation
    {
        public override float DoOperation(float number1, float number2)
        {
            return number1 * number2;
        }
    }
    class Divide : Operation
    {
        public override float DoOperation(float number1, float number2)
        {
            return number1 / number2;
        }
    }
}

}
