using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IOperator
{
    bool IsOperation(string symbol);
}
public class Symbol
{

}

public abstract class Operation : Symbol
{
    public abstract bool IsOperation(string symbol);
    public abstract Number DoOperation(Number data1, Number data2);
    public abstract string GetAsString();
}


public class Sum : Operation, IOperator
{
    public override Number DoOperation(Number data1, Number data2) => new Number(data1.GetNumber() + data2.GetNumber());
    public override string GetAsString() => "+";
    public override bool IsOperation(string symbol) => symbol == "+";
}
public class Subtraction : Operation, IOperator
{
    public override Number DoOperation(Number data1, Number data2) => new Number(data1.GetNumber() - data2.GetNumber());
    public override string GetAsString() => "-";
    public override bool IsOperation(string symbol) => symbol == "-";
}
public class Divide : Operation, IOperator
{
    public override Number DoOperation(Number data1, Number data2) => new Number(data1.GetNumber() / data2.GetNumber());
    public override string GetAsString() => "/";
    public override bool IsOperation(string symbol) => symbol == "/";
}
public class Multiply : Operation, IOperator
{
    public override Number DoOperation(Number data1, Number data2) => new Number(data1.GetNumber() * data2.GetNumber());
    public override string GetAsString() => "*";
    public override bool IsOperation(string symbol) => symbol == "*";
}