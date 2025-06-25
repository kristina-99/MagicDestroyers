namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Blunt;
    public class Druid
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private LeatherVest bodyArmor;
        private Staff weapon;

        public string Faction 
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    faction = "Spellcaster";
                    Console.WriteLine("Inappropriate faction! Should be \"Melee\" or \"Spellcaster\"");
                }
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    name = "no name";
                    Console.WriteLine("The name is too short or too long. Must be between 2 and 10 characters long.");
                }
            }
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    abilityPoints = 0;
                    Console.WriteLine("Inappropriate value! The ability points must be between 0 and 10.");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    healthPoints = value;
                }
                else
                {
                    healthPoints = 0;
                    Console.WriteLine("Inappropriate value! The health points must be between 0 and 120.");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    level = 0;
                    Console.WriteLine("Inappropriate value! Level must be between 0 and 100.");
                }
            }
        }

        public LeatherVest BodyArmor 
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Staff Weapon 
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Druid()
        {

        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}

