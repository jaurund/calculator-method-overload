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
        Console.WriteLine("Choose mode: single or list");
        string mode = Console.ReadLine().ToLower();

        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        if (!operations.ContainsKey(op))
        {
            Console.WriteLine("Unknown operator.");
            return;
        }

        if (mode == "single")
        {
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());

            double result = operations[op].Execute(a, b);
            Console.WriteLine($"Result: {result}");
        }
        else if (mode == "list")
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string[] input = Console.ReadLine().Split();
            List<double> numbers = new List<double>();

            foreach (var s in input)
            {
                if (double.TryParse(s, out double num))
                {
                    numbers.Add(num);
                }
            }

            double result = operations[op].Execute(numbers);
            Console.WriteLine($"Result: {result}");
        }
    }
}