
namespace ILoveYou;

public class CommandsManager
{
    public static void ExecuteCommands(string input)
    {
        switch (input)
        {
            case "1":
                ExecuteQuiz();
                break;
            case "2":
                ExecuteGallery();
                break;
            case "3":
                ExecuteNote();
                break;
            default:
                ConsolePersonalizer.ColorPrint("Please select a valid option from the menu", ConsoleColor.Red);
                break;
        }
    }

    private static void ExecuteQuiz()
    {
        ConsolePersonalizer.ColorPrint(
            "Welcome to the Quiz, my love :D \n\nHere are the rules:\n" +
            "1- Only I control the terminal \n2- You'll earn 1 point for correct answers\n" +
            "3- You'll earn 2 points for making me laugh \n4- You'll earn 3 points for saying something romantic"
            , ConsoleColor.Blue);

        QuizHelper quizHelper = new();

        while (quizHelper.QuizCounter < QuizHelper.Questions.Length)
        {
            QuizHelper.DisplayQuestion(quizHelper.QuizCounter);
            quizHelper.QuizCounter++;
        }
        QuizHelper.ShowScore();
        Console.WriteLine("Press Enter to exit");
        Console.ReadLine();
        Intro();
    }

    private static void ExecuteGallery()
    {
        ConsolePersonalizer.ColorPrint(
            "Welcome to the Message Gallery, my love. Here you'll find messages I've collected.\n" +
            "You'll discover funny and sweet moments that I hope will make you smile :3"
            , ConsoleColor.Blue);

        MessagesHelper messagesHelper = new();

        while (messagesHelper.Position < MessagesHelper.Messages.Length)
        {
            MessagesHelper.DisplayMessages(messagesHelper.Position);
            messagesHelper.Position++;
        }

        Intro();
    }

    private static void ExecuteNote()
    {
        ConsolePersonalizer.ColorPrint(
            "Hello my love, how are you? :3 I hope you're enjoying your gift as much \n" +
            "as I enjoyed creating it for you. I've been looking forward to this moment \n" +
            "when you could finally see it. Truthfully, I'm not sure what else to put in \n" +
            "this section XD so I'll dedicate these words to you:\n\n" +
            "I love you, I love you in ways I never thought possible again\n" +
            "I thought love was something I might never experience fully\n" +
            "But you decided to accept me, decided I was important\n" +
            "And I'm truly grateful that you chose to be in my life.\n" +
            "Your very existence gives me reason to live another day,\n" +
            "a reason to strive each day to become my best self.\n" +
            "I simply want to be everything for you, just as you are everything to me. I love you :D"
            , ConsoleColor.Blue);
        Console.ReadLine();

        Intro();
    }

    //If you want to make your own name with ASCII ART there is a lot of webs for that 
    public static void Intro()
    {
        ConsolePersonalizer.ColorPrint($@"
  __  __           __  __                 ____             
 |  \/  | __ _ ___|  \/  | ___  _ __ _ __|  _ \  _____   __
 | |\/| |/ _` |_  / |\/| |/ _ \| '__| '__| | | |/ _ \ \ / /
 | |  | | (_| |/ /| |  | | (_) | |  | |  | |_| |  __/\ V / 
 |_|  |_|\__,_/___|_|  |_|\___/|_|  |_|  |____/ \___| \_/  
                                                           
┌──────────────────────────────────────────────────────────┐
│                                                          │
│  Hello my love, I hope you like your gift {Parameters.GiveHeartEmoji}│
│                                                          │
│  1. Quiz                              2. Messages        │
│  3. Love Note                         4. Exit            │
│                                                          │
└──────────────────────────────────────────────────────────┘",
 ConsoleColor.Yellow);

        // Reset helpers for fresh start
        MessagesHelper galleryHelper = new();
        QuizHelper quizHelper = new();
        galleryHelper.Position = 0;
        quizHelper.QuizCounter = 0;
    }
}