using KingdomofKatsamany.Characters.SerializeDeserialize;


namespace KingdomofKatsamany
{
    public class GameService
    {
        public static void BeforeStartGame()
        {
            Name.InputName();
        }

        public static void StartGame()
        {
            

            /*var initialAdventure = adventureService.GetInitialAdventure();
            var initialCharacter = characterService.LoadInitialCharacter();

            Console.WriteLine($"Adventure : {initialAdventure.Title}");
            Console.WriteLine($"Description : {initialAdventure.Description}");

            Console.WriteLine($"Character Name : {initialCharacter.Name}");
            Console.WriteLine($"Level : {initialCharacter.Level}");*/
        }
    }
}
