using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Divide : IOperation
{
    public double Execute(double a, double b)
    {
        if (a == 0 && b == 0)
        {
            ErrorMessages.DivideZeroByZero(a, b);
            return double.NaN;
        }
        if (b == 0)
        {
            ErrorMessages.DivideByZero(a);
            return double.NaN;
        }
        if (a == 0)
        {
            ErrorMessages.DivideZeroByNumber(b);
            return double.NaN;
        }
        return a / b;
    }
}
