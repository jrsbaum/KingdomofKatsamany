namespace KingdomofKatsamany.Characters.SerializeDeserialize
{
    class Character
    {
        private string _characterName;        
        public int LifePoints = 10;
        public int ManaPoints = 12;

        public Character(string characterName)
        {
            _characterName = characterName;
        }
        public Character(int lifePoints, int manaPoints)
        {
            LifePoints = lifePoints;
            ManaPoints = manaPoints;
        }

        public override string ToString()
        {
            return "Name: " + _characterName + ", Vida: " + LifePoints + ", Mana: " + ManaPoints;
        }

    }
}
