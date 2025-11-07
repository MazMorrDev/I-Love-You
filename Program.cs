using ILoveYou;

CommandsManager.Intro();

while (true)
{
    Console.Write("> ");

    string input = (Console.ReadLine() ?? "").Trim();
    if (input == "4")
    {
        ConsolePersonalizer.ColorPrint($"Dale ponte en 4 {Parameters.Emoji4}", ConsoleColor.Green);
        return;
    }

    CommandsManager.ExecuteCommands(input);

}

