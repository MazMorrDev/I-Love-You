namespace ILoveYou;

public class ConsolePersonalizer
{


    public static void ColorPrint(string text, ConsoleColor color)
    {
        Console.WriteLine("");
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
        Console.WriteLine("");
    }
}
