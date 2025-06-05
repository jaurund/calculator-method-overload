using System;

public static class InputValidator
{
    public static bool TryParseInput(string input, out double result)
    {
        return double.TryParse(input, out result);
    }

    public static bool IsValidOperator(string op)
    {
        return op == "+" || op == "-" || op == "*" || op == "/";
    }
}
