using System.Collections.Generic;

public interface IOperation
{
    double Execute(double a, double b);
    double Execute(List<double> numbers); // overloaded version
}