using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;

public class Printer
{
    public static void TypeWriter(string text, int baseDelay = 30)
    {
        Random rand = new Random();
        bool slowMode = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text.Substring(i).StartsWith("<slow>"))
            {
                slowMode = true;
                i += "<slow>".Length - 1;
                continue;
            }
            if (text.Substring(i).StartsWith("</slow>"))
            {
                slowMode = false;
                i += "</slow>".Length - 1;
                continue;
            }

            Console.Write(text[i]);

            int delay = baseDelay;
            if (slowMode)
            {
                delay *= 4; // 4x seinare skriving
            }
            else if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?')
            {
                delay *= 6;
            }
            else if (char.IsWhiteSpace(text[i]))
            {
                delay *= 2;
            }
            else
            {
                delay = rand.Next(delay, delay + 40);
            }

            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
}