using KingdomofKatsamany.Entities.Interfaces;
using KingdomofKatsamany.Entities.Models;
using Newtonsoft.Json;


namespace KatsamanysKingdom.Entities
{
    public class CharacterService : ICharacterService
    {
        
        public Character LoadInitialCharacter()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var initialCharacter = new Character();

            if (File.Exists($"{basePath}\\kat.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("kat.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }
            }

            return initialCharacter;
        }

        
    }
}
