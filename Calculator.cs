public class Calculator
{
    private readonly Dictionary<string, IOperation> operations;

    public Calculator()
    {
        operations = new Dictionary<string, IOperation>
        {
            { "+", new Add() },
            { "-", new Subtract() },
            { "*", new Multiply() },
            { "/", new Divide() },
        };
    }

    public void Run()
    {
        Console.WriteLine("Enter first number:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        double b = double.Parse(Console.ReadLine());

        if (operations.ContainsKey(op))
        {
            double result = operations[op].Execute(a, b);
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Unknown operator.");
        }
    }
}
