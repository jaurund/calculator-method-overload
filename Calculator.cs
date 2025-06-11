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

    public bool Run()
    {
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Start typing to calculate, or type 'exit' to quit:");
        string? input = Console.ReadLine(); // Allow null

        if (input.ToLower() == "exit")
        {
            return false; // Exit the loop
        }

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input or no input provided.");
            return true;
        }
        input = input.Trim();

        if (double.TryParse(input, out double firstNumber))
        {
            Console.WriteLine("Enter an operator (+, -, *, /):");
            string? op = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(op))
            {
                Console.WriteLine("Invalid operator.");
                return true;
            }
            op = op.Trim();
            if (!operations.ContainsKey(op))
            {
                Console.WriteLine("Unknown operator.");
                return true;
            }
            Console.WriteLine("Enter second number:");
            string? secondInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(secondInput) || !double.TryParse(secondInput.Trim(), out double secondNumber))
            {
                Console.WriteLine("Invalid number.");
                return true;
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
        return true;
    }
}
