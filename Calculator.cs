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
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Start typing to calculate:");
        string input = Console.ReadLine().Trim();

        if (double.TryParse(input, out double firstNumber))
        {
            Console.WriteLine("Enter an operator (+, -, *, /):");
            string op = Console.ReadLine().Trim();
            if (!operations.ContainsKey(op))
            {
                Console.WriteLine("Unknown operator.");
                return;
            }
            Console.WriteLine("Enter second number:");
            if (!double.TryParse(Console.ReadLine().Trim(), out double secondNumber))
            {
                Console.WriteLine("Invalid number.");
                return;
            }
            double result = operations[op].Execute(firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");
        }
        else if (
                   input.Contains("+")
                || input.Contains("-")
                || input.Contains("*")
                || input.Contains("/")
                || input.Contains("(")
                || input.Contains(")")
                )
        {
            try
            {
                double result = new ExpressionParser().Parse(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing expression: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
