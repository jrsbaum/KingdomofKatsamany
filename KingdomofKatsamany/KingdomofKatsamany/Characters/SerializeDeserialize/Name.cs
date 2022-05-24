namespace KingdomofKatsamany.Characters.SerializeDeserialize
{
    public class Name
    {        
        public static void InputName()
        {
            Character InputName = new Character();

            Console.WriteLine("Give your character a name: ");
            
            InputName.setCharacterName(Console.ReadLine());
            var result = InputName.getCharacterName();
            if(result == string.Empty)
            {
                Console.WriteLine("Empty name. Please, type again");
                Name.InputName();
            }
            if (result.All(char.IsDigit))
            {
                Console.WriteLine("The name can't be a number. Please, type again");
                Name.InputName();
            }
            else
            {
                Console.WriteLine($"The name chosen was {result}.");
                Console.ReadKey();
                Console.Clear();
                Gui.ClassChoice();
            }

        } 
    }
}
