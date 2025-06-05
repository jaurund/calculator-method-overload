using System;
using System.Collections.Generic;

public class Divide : IOperation
{
    public double Execute(double a, double b)
    {
        if (b == 0)
        {
            Printer.TypeWriter("Why do you think I can't let you divide by zero?\n", 30);
            Printer.TypeWriter("It's because I don't want to see you fail.\n", 30);
            return double.NaN;
        }

        return a / b;
    }
}
