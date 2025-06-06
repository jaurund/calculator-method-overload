using System;
using System.Collections.Generic;

public class Add : IOperation
{
    public double Execute(double a, double b)
    {
        return a + b;
    }
    public double Execute(List<double> numbers)
    {
        if (numbers.Count == 0) return 0; // No numbers = default to 0 (could also throw exception)

        double result = 1;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
}
