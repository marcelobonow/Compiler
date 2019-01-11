using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Number : Symbol
{
    private readonly float value;

    public Number(float value) => this.value = value;
    public float GetNumber() => value;

    //public static Number operator +(Number data1, Number data2) => Sum.DoOperation(data1, data2);
    //public static Number operator -(Number data1, Number data2) => Subtraction.DoOperation(data1, data2);
    //public static Number operator *(Number data1, Number data2) => Multiply.DoOperation(data1, data2);
    //public static Number operator /(Number data1, Number data2) => Divide.DoOperation(data1, data2);
    public override string ToString() => value.ToString();
}
