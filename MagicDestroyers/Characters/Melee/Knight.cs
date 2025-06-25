namespace MagicDestroyers.Characters.Melee
{
    using System;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Weapons.Blunt;
    public class Knight
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Chainlink bodyArmor;
        private Hammer weapon;

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
                if (value >= 0 && value <= 25)
                {
                    abilityPoints = value;
                }
                else
                {
                    abilityPoints = 0;
                    Console.WriteLine("Inappropriate value! The ability points must be between 0 and 25.");
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

        public Chainlink BodyArmor 
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
        public Hammer Weapon 
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

        public Knight()
        {

        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}