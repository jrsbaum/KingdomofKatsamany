namespace KingdomofKatsamany.Characters.SerializeDeserialize
{
    public class Name
    {        
        public static void CharacterName()
        {            
            Console.WriteLine("Give your character a name: ");                        
            string characterName = (Console.ReadLine());

            if (characterName == string.Empty | characterName == " ")
            {
                Console.WriteLine("Empty name. Please, type again");
                CharacterName();
            }
            if (characterName.All(char.IsDigit))
            {
                Console.WriteLine("The name can't be a number. Please, type again");
                CharacterName();
            }
            else
            {
                Thread.Sleep(20);
            }

            Character c = new Character(characterName);
            Console.WriteLine($"The name chosen was: ~{characterName}~.");
            Thread.Sleep(2000);

            Console.Clear();
            Class.ClassChoice();




        }
    }
}
