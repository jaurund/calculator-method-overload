using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        while (true)
        {
            Console.WriteLine("\nEnter operation (add, subtract, multiply, divide) or 'exit' to quit:");
            string operation = Console.ReadLine().Trim().ToLower();

            if (operation == "exit") break;

            Console.WriteLine("Enter numbers separated by comma (eg. 1,2,3):");
            string input = Console.ReadLine();
            double[] numbers = input.Split(',').Select(nameof => double.Parse(nameof.Trim())).ToArray();

            double result = operation switch
            {
                "add" => numbers.Length == 2 ? calc.Add(numbers[0], numbers[1]) : calc.Add(numbers),
                "subtract" => numbers.Length == 2 ? calc.Subtract(numbers[0], numbers[1]) : calc.Subtract(numbers),
                "multiply" => numbers.Length == 2 ? calc.Multiply(numbers[0], numbers[1]) : calc.Multiply(numbers),
                "divide" => numbers.Length == 2 ? calc.Divide(numbers[0], numbers[1]) : Calculator.Divide(numbers),
                _ => double.NaN
            };

            Console.WriteLine($"Result: {result}");
        }
    }
}