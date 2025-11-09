namespace ILoveYou;

public class MessagesHelper
{
    public int Position { get; set; } = 0;
    public static readonly string[] Messages = [
        "Someday I'm going to trace your abs with my tongue and feel every contour \n10:40 PM   September 23, 2025",
        "Confident energy attracts so much more than anything else \n8:29 PM   July 31, 2025",
        "Hello there. Just thinking of you \n5:17 PM   July 30, 2025",
        "If I can't be by your side, then I'll be in your thoughts \n6:36 PM   September 23, 2025",
        "The storm is coming, hope the power stays on\n5:53 PM   September 23, 2025",
        "Made it home safely\n11:42 AM   September 11, 2025",
        "Look at this, reminds me of that time we laughed so hard\n10:16 PM   September 11, 2025",
        "I don't just like you. I love you. There's a difference\n10:03 PM   September 30, 2025",
        "I can't wait to see you\n6:10 PM   October 4, 2025",
        "And to think that this wonderful feeling is all mine\n6:13 AM   October 14, 2025"
    ];

    public static void DisplayMessages(int messagePosition)
    {
        Console.WriteLine($"{messagePosition + 1}/{Messages.Length}");
        ConsolePersonalizer.ColorPrint(Messages[messagePosition], ConsoleColor.Magenta);
        Console.ReadLine();
    }
}