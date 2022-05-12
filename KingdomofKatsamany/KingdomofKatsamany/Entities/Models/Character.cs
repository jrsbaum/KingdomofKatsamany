using KingdomofKatsamany.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingdomofKatsamany.Entities.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Energy;
        public int Mana;
        public int Gold;
        public string Background;
        public int Inventoryweight;

        public Skills Skills;
        public List<string> AdventuresPlayed;
        public bool IsAlivel;
        public int ArmorClass;
        public List<IItems> Inventory;
        public int HitPoints;

        public Character()
        {

        }

        public void MyMethod()
        {

        }

    }

    public class Skills
    {
        //OffensiveSkills
        public int AttackDamage; //ad
        public int CriticalDamage;

        public int MagicPower; //ap
        public int CriticalPower;

        //DefensiveSkills
        public int Armor;
        public int MagicResistance;
        public int Life;
        public int RegenLife;
        public int RegenEnergy;
        public int RegendMana;
    }


}