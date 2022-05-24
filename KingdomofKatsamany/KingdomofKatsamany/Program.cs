using KingdomofKatsamany.Characters.SerializeDeserialize;

namespace KingdomofKatsamany
{
    class Program
    {         
        static void Main(string[] args)
        {

            Console.ReadKey();
                        
            Gui.Presenting();
            Gui.MakeTitle();
            Gui.MainMenu();
            Gui.ClassChoice();
            Name.InputName();

        }
    }
}

