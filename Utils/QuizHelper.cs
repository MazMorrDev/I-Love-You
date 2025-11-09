namespace ILoveYou;

public class QuizHelper
{
    public int QuizCounter { get; set; } = 0;
    private static int QuizScore = 0;
    
    // Data structure for questions
    public static readonly QuizQuestion[] Questions = 
    [
        new("What's my favorite color?", 
            ["Blue", "Red", "Green", "Yellow"]),
            
        new("Which of your gifts has been my favorite?", 
            ["Photo album", "The Cake", "The Bracelet", "The Poem"], 
            Parameters.ShameEmoji),
            
        new("What do I do when I'm nervous?", 
            ["Bite my nails", "Laugh nervously", "Stutter when talking", "Play with my hair"], 
            Parameters.AlertEmoji),
            
        new("What would I do for work in a parallel life?", 
            ["Electrician", "Carpenter", "Musician", "Chef"], 
            Parameters.CatEmoji),
            
        new("Which song reminds me of you?", 
            ["Perfect - Ed Sheeran", "Yellow - Coldplay", "Do I Wanna Know - Arctic Monkeys", "Die For You - The Weeknd"], 
            Parameters.MusicEmoji),
            
        new("Am I in love with you?", 
            ["Yes", "Yes", "Yes", "Yes"], 
            Parameters.GiveHeartEmoji),
            
        new("What's my secret superpower?", 
            ["Making funny faces", "Knowing when you have a problem", "Making you smile unintentionally", "Loving you more every day"], 
            Parameters.FitnessEmoji),
            
        new("What do I love most about you?", 
            ["Your smile", "Your intelligence", "Your personality", "Your sense of humor"], 
            Parameters.GiveHeartEmoji),
            
        new("Where would be our ideal date?", 
            ["At home watching movies", "At the beach at sunset", "At a restaurant", "Anywhere with you"], 
            Parameters.GiveHeartEmoji),
            
        new("How much do I love you?", 
            ["A lot", "So much", "Infinitely", "More than words can express"], 
            Parameters.GiveHeartEmoji)
    ];

public static void DisplayQuestion(int quizCounter)
{
    if (quizCounter >= Questions.Length)
    {
        Console.WriteLine("An error occurred while displaying the question");
        return;
    }

    var question = Questions[quizCounter];
    ShowQuestion(question.Text, question.Answers, question.Emoji);
    
    while (true)
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out int answer) && answer >= 1 && answer <= 3)
        {
            QuizScore += answer;
            break;
        }
        else
        {
            ConsolePersonalizer.ColorPrint("Please enter a valid number between 1 and 4:", ConsoleColor.Red);
            Console.Write("➤ ");
        }
    }
}

    public static void ShowScore()
    {
        ConsolePersonalizer.ColorPrint($"Your final score is: {QuizScore}!!!", ConsoleColor.Cyan);
    }

    private static void ShowQuestion(string question, string[] answers, string emoji = Parameters.CatEmoji)
    {
        ConsolePersonalizer.ColorPrint(question + " " + emoji, ConsoleColor.Magenta);
        ShowAnswers(answers);
        Console.Write("➤ ");
    }

    private static void ShowAnswers(string[] answers)
    {
        ConsolePersonalizer.ColorPrint($"1. {answers[0]}    2. {answers[1]}", ConsoleColor.Gray);
        ConsolePersonalizer.ColorPrint($"3. {answers[2]}    4. {answers[3]}", ConsoleColor.Gray);
    }

    // Helper class to represent a question
    public record QuizQuestion(string Text, string[] Answers, string Emoji = Parameters.CatEmoji);
}