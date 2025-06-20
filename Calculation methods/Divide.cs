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

    public double Execute(List<double> numbers)
    {
        if (numbers.Count == 0) return 0; // No numbers = default to 0 (could also throw exception)

        double result = 1;
        foreach (var number in numbers)
        {
            result /= number;
        }
        return result;
    }
}
