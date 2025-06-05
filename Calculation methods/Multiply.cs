using System;
using System.Collections.Generic;

public class Multiply : IOperation
{
    public double Execute(double a, double b)
    {
        return a * b;
    }
}