namespace KingdomofKatsamany.Characters.SerializeDeserialize
{
    static class Serialize
    {
        public static string? NewCharacter()
        {
            Console.WriteLine("Good Job! Give your character a name: ");
            Console.WriteLine();
            
            var characterName = ;

            while (!characterName)
            {                
                var characterName = Console.ReadLine();
                Console.WriteLine($"Ok! {characterName} seems to be a good name.");

                Gui.ClassChoice();
            return characterName;

        }
    }

}
