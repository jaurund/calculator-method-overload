using System;

public static class ErrorMessages
{
    public static void DivideByZero(double a)
    {
        TextEffects.TypeWriter("Why do you think I can't let you divide by zero?");
        TextEffects.TypeWriter($"Well, imagine that you have {a} cookies and you split them evenly among zero friends.");
        TextEffects.TypeWriter("How many cookies does each person get?");
        TextEffects.TypeWriter("See? It doesn't make sense. Cookie monster is happy that there is cookies, <slow>but,</slow>");
        TextEffects.TypeWriter("you are sad that you still have no friends.");
    }

    public static void DivideZeroByZero(double a, double b)
    {
        TextEffects.TypeWriter("Well, I can't let you do that.");
        TextEffects.TypeWriter($"Imagine that you have zero cookies and you split them evenly among zero friends.");
        TextEffects.TypeWriter("How many cookies does each person get?");
        TextEffects.TypeWriter("See? It doesn't make sense. And Cookie Monster is sad that there are no cookies.");
        TextEffects.TypeWriter("And you are sad that you have no friends.");
    }

    public static void DivideZeroByNumber(double b)
    {

        TextEffects.TypeWriter("Well, you've tried to divide zero by something.");
        TextEffects.TypeWriter($"Imagine that you have zero cookies, but you split them evenly among {b} friends.");
        TextEffects.TypeWriter("How many cookies does each person get?");
        TextEffects.TypeWriter("See? It doesn't make sense. And Cookie Monster is sad that there are no cookies.");
        TextEffects.TypeWriter("And you are sad that all your friends left you because you didn't have any cookies to give them.");
    }
}
