using KatsamanysKingdom.Entities;
using KingdomofKatsamany.Adventures;

namespace KingdomofKatsamany
{
    class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);
        static void Main(string[] args)

        {

            Console.ReadKey();

            Gui.Presenting();
            Gui.MakeTitle();
            Gui.MainMenu(gameService);
            
        }
    }
}

