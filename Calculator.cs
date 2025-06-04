using System;
using System.Linq;

public class Calculator
{
    public double Add(double a, double b) => a + b;
    public double Add(double[] numbers) => numbers.Sum();

    public double Subtract(double a, double b) => a - b;
    public double Subtract(double[] numbers) => numbers.Aggregate((a, b) => a - b);

    public double Multiply(double a, double b) => a * b;
    public double Multiply(double[] numbers) => numbers.Aggregate((a, b) => a * b);

    public double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
    public static double Divide(double[] numbers) => numbers.Aggregate((a, b) => b != 0 ? a / b : double.NaN);
}
