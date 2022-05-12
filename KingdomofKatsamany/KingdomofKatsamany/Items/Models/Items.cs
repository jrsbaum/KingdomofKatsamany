using KingdomofKatsamany.Items.Interfaces;

namespace KingdomofKatsamany.Items.Models
{
    public class Items : IItems
    {
        public ItemsType Name;
        public string Description;
        public int ObjectiveNumber;
        public int Weight;
        public int GoldValue;

    }

    public enum ItemsType
    {
        //Swords
        SmallSword,
        Sword,
        GoldenSword,
        LegendarySword,

        //Shields
        SmallShield,
        Shield,
        GoldenShied,
        LegendaryShield,

        //Staff
        SmallStaff,
        Staff,
        GoldenStaff,
        LegendaryStaff,

        //Cloak
        SmallCloak,
        Cloak,
        GoldenCloak,
        LegendaryCloak,

        //Boot
        SimpleBoot,
        BootOfSpeed,
        GoldenBoot,
        LegenderayBoot,

        //Consumables
        SmallHealtyPotion,
        MediumHealtyPotion,
        BigHealtyPotion,

        SmallManaPotion,
        MediumManaPotion,
        BigManaPotion,
    }
}
