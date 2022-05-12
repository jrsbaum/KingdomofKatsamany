using KingdomofKatsamany.Adventures.Interfaces;
using KingdomofKatsamany.Entities.Interfaces;

namespace KingdomofKatsamany
{
    public class GameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;

        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }

        public void StartGame()
        {
            Gui.ClassChoice();            
            /*var initialAdventure = adventureService.GetInitialAdventure();
            var initialCharacter = characterService.LoadInitialCharacter();

            Console.WriteLine($"Adventure : {initialAdventure.Title}");
            Console.WriteLine($"Description : {initialAdventure.Description}");

            Console.WriteLine($"Character Name : {initialCharacter.Name}");
            Console.WriteLine($"Level : {initialCharacter.Level}");
            */
        }
    }
}