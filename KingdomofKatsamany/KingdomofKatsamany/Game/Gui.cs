using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingdomofKatsamany
{
    class Gui
    {
        static public void Presenting()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Kingdom of Katsamany!");
            Console.ReadKey();
            Console.WriteLine("This is a Console RPG made to improve " +
                              "and show my skills in .NET development.");
            Console.ReadKey();
            Console.WriteLine("Ahh... here is my linkedIn and my github.");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("LinkedIn: /juniorbaum");
            Console.ReadKey();
            Console.WriteLine("GitHub: /jrsbaum");
            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.WriteLine("I hope you enjoy it! Have a good time!");
            Console.ReadKey();

            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
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

            Console.ReadKey();
            Console.BackgroundColor = default;
            Console.ForegroundColor = ConsoleColor.White;

        }                

        public static void MainMenu(GameService gameService)
        {
            Console.WriteLine();
            MainMenuOptions();
            var inputValid = false;

            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.BeforeStartGame(gameService);
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
                        MainMenu(gameService);
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
        public static void CharacterName(GameService gameService)
        {
            Console.WriteLine("Good Job! Give your character a name: ");
            string characterName = Console.ReadLine();
            Console.WriteLine($"Ok! {characterName} seems to be a good name.");
          
            
            
            Console.WriteLine();
            ClassChoice(gameService);
        }

        public static void ClassChoice(GameService gameService)
        {
            Console.WriteLine();
            ClassChoiceOptions();
            var inputValid = false;

            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "W":
                        Console.WriteLine("You chose Warrior.");
                        Console.WriteLine(" ");
                        gameService.StartGame();
                        break;

                    case "M":
                        Console.WriteLine("You chose Mage.");
                        Console.WriteLine(" ");
                        gameService.StartGame();
                        break;

                    case "R":
                        Console.WriteLine("You chose Rogue.");
                        Console.WriteLine(" ");
                        gameService.StartGame();
                        break;

                    default:
                        Console.WriteLine("umm... you didnt pick the right letter." +
                                           "try again");
                        ClassChoice(gameService);
                        inputValid = false;
                        break;
                                                
                }
            }

        }
        public static void ClassChoiceOptions()
        {
            Console.WriteLine("Which class do you choose?");
            Console.WriteLine("(W)arrior");
            Console.WriteLine("(M)age");
            Console.WriteLine("(R)ogue");
        }                

    }      
}