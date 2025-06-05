using System;
using System.Collections.Generic;

public class Add : IOperation
{
    public double Execute(double a, double b)
    {
        return a + b;
    }
}