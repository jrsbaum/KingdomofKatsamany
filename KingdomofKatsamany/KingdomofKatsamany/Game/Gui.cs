using KingdomofKatsamany.Characters.SerializeDeserialize;

namespace KingdomofKatsamany
{
    class Gui
    {
        static public void Presenting()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Kingdom of Katsamany!");            
            Thread.Sleep(1500);
            Console.WriteLine("This is a Console RPG made to improve " +
                              "and show my skills in .NET development.");            
            Thread.Sleep(1500);
            Console.WriteLine("Ahh... here is my linkedIn and my github.");            
            Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("LinkedIn: /juniorbaum");
            Thread.Sleep(1500);
            Console.WriteLine("GitHub: /jrsbaum");
            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
            Console.WriteLine("I hope you enjoy it! Have a good time!");
            Thread.Sleep(1500);
            Console.WriteLine("(press enter)");
            Console.ReadKey();

            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;          
            
            Console.Clear();

        }

        public static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("************************************");
            Console.WriteLine("*                                  *");
            Console.WriteLine("*   ┬ ┬┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐  *");
            Console.WriteLine("*   │││├┤ │  │  │ ││││├┤    │ │ │  *");
            Console.WriteLine("*   └┴┘└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘  *");
            Console.WriteLine("*    ┬┌─┬┌┐┌┌─┐┌┬┐┌─┐┌┬┐  ┌─┐┌─┐   *");
            Console.WriteLine("*    ├┴┐│││││ ┬ │││ ││││  │ │├┤    *");
            Console.WriteLine("*    ┴ ┴┴┘└┘└─┘─┴┘└─┘┴ ┴  └─┘└     *");
            Console.WriteLine("*    ┬┌─┌─┐┌┬┐┌─┐┌─┐┌┬┐┌─┐┌┐┌┬ ┬   *");
            Console.WriteLine("*    ├┴┐├─┤ │ └─┐├─┤│││├─┤│││└┬┘   *");
            Console.WriteLine("*    ┴ ┴┴ ┴ ┴ └─┘┴ ┴┴ ┴┴ ┴┘└┘ ┴    *");
            Console.WriteLine("*                                  *");
            Console.WriteLine("************************************");

            Thread.Sleep(1500);
            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void MainMenu()
        {
            Console.WriteLine();
            MainMenuOptions();
            var inputValid = false;

            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        GameService.BeforeStartGame();
                        break;

                    case "L":
                        LoadGame.StartLoadGame();
                        break;

                    case "O":
                        Options.NewOptions();
                        inputValid = true;
                        break;

                    default:
                        Console.WriteLine("umm... you didnt pick the right letter." +
                                           "try again");
                        MainMenu();
                        inputValid = false;
                        break;
                }
            }
            Console.ReadKey();
            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
        }

        public static void MainMenuOptions()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(O)ptions");
        }
        

        

    }
}
