namespace ILoveYou;

public class QuizHelper
{
    public int QuizCounter { get; set; } = 1;
    private static int QuizScore = 0;
    
    // Estructura de datos para las preguntas
    private static readonly QuizQuestion[] Questions = 
    {
        new("¿Cuál es mi color favorito?", 
            ["Azul", "Rojo", "Verde", "Amarillo"]),
            
        new("De todos tus regalos cuál ha sido mi favorito?", 
            ["Fotos de Forbe", "El Cake", "El Pulsito", "El Verso"], 
            Parameters.ShameEmoji),
            
        new("¿Qué hago cuando estoy nervioso/a?", 
            ["Comerme las uñas", "Reírme a lo pendejo", "Trabarme al hablar", "Jugar con el cabello"], 
            Parameters.AlertEmoji),
            
        new("¿De qué trabajaría en una vida paralela?", 
            ["Electricista", "Carpintero", "Músico", "Chef"], 
            Parameters.CatEmoji),
            
        new("¿Qué canción me recuerda a ti?", 
            ["Perfect - Ed Sheeran", "Yellow - Coldplay", "Do I Wanna Know - Artic Monkeys", "Die For You - The Weeknd"], 
            Parameters.MusicEmoji),
            
        new("¿Estoy enamorado de tí?", 
            ["Sí", "Sí", "Sí", "Sí"], 
            Parameters.GiveHeartEmoji),
            
        new("¿Cuál es mi superpoder secreto?", 
            ["Poner caras raras", "Saber cuando tienes un problema", "Hacerte sonreír sin querer", "Amarte cada día más"], 
            Parameters.GiveHeartEmoji),
            
        new("¿Qué me gusta más de tí?", 
            ["Tu sonrisa", "Tu inteligencia", "Tu forma de ser", "Tu culo"], 
            Parameters.GiveHeartEmoji),
            
        new("¿Dónde sería nuestra cita ideal?", 
            ["En casa viendo películas", "En la playa al atardecer", "En un restaurante", "Cualquier lugar contigo"], 
            Parameters.GiveHeartEmoji),
            
        new("¿Cuánto te amo?", 
            ["Mucho", "Muchísimo", "Infinito", "Más de lo que las palabras pueden expresar"], 
            Parameters.GiveHeartEmoji)
    };

    public static void DisplayQuestion(int quizCounter)
    {
        if (quizCounter < 1 || quizCounter > Questions.Length)
        {
            Console.WriteLine("Ocurrió un error mientras se desplegaba la pregunta");
            return;
        }

        if (quizCounter == Questions.Length)
        {
            ShowScore();
            return;
        }

        var question = Questions[quizCounter - 1];
        ShowQuestion(question.Text, question.Answers, question.Emoji);
        QuizScore += int.Parse(Console.ReadLine() ?? "0");
    }

    private static void ShowScore()
    {
        ConsolePersonalizer.ColorPrint($"¡¡¡Tu puntuación final es: {QuizScore}!!!", ConsoleColor.Cyan);
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

    // Clase auxiliar para representar una pregunta
    private record QuizQuestion(string Text, string[] Answers, string Emoji = Parameters.CatEmoji);
}