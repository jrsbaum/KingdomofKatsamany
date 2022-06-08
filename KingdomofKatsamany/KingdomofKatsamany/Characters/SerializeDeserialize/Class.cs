using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingdomofKatsamany.Characters.SerializeDeserialize
{
    class Class
    {
        public static void ClassChoice()
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
                        GameService.StartGame();
                        break;

                    case "M":
                        Console.WriteLine("You chose Mage.");
                        Console.WriteLine(" ");
                        GameService.StartGame();
                        break;

                    case "R":
                        Console.WriteLine("You chose Rogue.");
                        Console.WriteLine(" ");
                        GameService.StartGame();
                        break;

                    default:
                        Console.WriteLine("umm... you didnt pick the right letter." +
                                           "try again");
                        ClassChoice();
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
