
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
                ConsolePersonalizer.ColorPrint("Oe estás tocando cositas mal 7-7", ConsoleColor.Red);
                break;
        }
    }

    private static void ExecuteQuiz()
    {
        ConsolePersonalizer.ColorPrint(
            "Bienvenida al Quiz mi amor :D \n\nProcedo a Explicarte las reglas:\n" +
            "1- Solo yo escribo en la terminal \n2- Ganarás 1 punto por acertar las respuestas disponibles\n" +
            "3- Ganarás 2 puntos por decir algo gracioso \n4- Ganarás 3 puntos por decir algo romántico 7w7"
            , ConsoleColor.Blue);
        QuizHelper quizHelper = new();
        while (quizHelper.QuizCounter < 11)
        {
            QuizHelper.DisplayQuestion(quizHelper.QuizCounter);
        }

        ExecuteNote();
    }

    private static void ExecuteGallery()
    {

        Intro();
    }

    private static void ExecuteNote()
    {
        ConsolePersonalizer.ColorPrint(
            "Hola, amor, este mensaje te lo escribo el Jueves, 6 de noviembre de 2025. \n" +
            "Este es el día en que decidí irme de tu casa, seguramente ya hayan pasado unos \n" +
            "días. Y bueno, espero que todo este mal sentir ya sea cosa del pasado, \n" +
            "desearía que todo quedase simplemente en un juego tonto como tantos otros, \n" +
            "pero bueno yo también tengo mis cosas que me hacen sentir insuficiente o indigno \n" +
            "o en general el sinónimo que quieras buscarle a esas palabras, el caso es que \n" +
            "realmente me dolió ver como actuaste conmigo, por favor no me hagas mal \n" +
            "ni intentes minimizar mis esfuerzos por abrirme contigo porq realmente duelen, \n" +
            "especialmente sabiendo que eres la persona que amo :( enserio lo hago. Sin \n)" +
            "más, espero que este mensaje te haga recordar que yo también por muy fuerte, pitudo \n" +
            "pelilargo y mocongo que sea, también requiero de tu comprensión y apoyo. Te amo :3"
            , ConsoleColor.Blue);

        Intro();
    }

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
│  Hola mi amor, espero que te guste tu regalo {Parameters.GiveHeartEmoji}│
│                                                          │
│  1. Quizz                             2. Galería         │
│  3. Notita                            4. Salir           │
│                                                          │
└──────────────────────────────────────────────────────────┘",
 ConsoleColor.Yellow);
    }
}
