using System;
using System.Collections.Generic;

public class Divide : IOperation
{
    public double Execute(double a, double b)
    {
        if (b == 0)
        {
            Printer.TypeWriter("Why do you think I can't let you divide by zero?\n", 60);
            Printer.TypeWriter("Well, imagine that you have zero cookies and you split them evenly among zero friends. How many cookies does each person get?\n\nSee? It doesn't make sense. And Cookie Monster is sad that there are no cookies. And you are sad that you have no friends.", 60);
            return double.NaN;
        }

        return a / b;
    }
}
