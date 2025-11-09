using ILoveYou;


CommandsManager.Intro();
while (true)
{
    Console.Write("> ");

    string input = (Console.ReadLine() ?? "").Trim();
    if (input == "4")
    {
        ConsolePersonalizer.ColorPrint($"Thanks for experiencing this with me {Parameters.ShameEmoji}", ConsoleColor.Green);
        return;
    }

    CommandsManager.ExecuteCommands(input);
}