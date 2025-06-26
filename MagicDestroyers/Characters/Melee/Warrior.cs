namespace MagicDestroyers.Characters.Melee
{
    using System;
    using MagicDestroyers.Armors.Cloth;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Weapons.Sharp;
    public class Warrior
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Chainlink bodyArmor;
        private Axe weapon;

        public string Faction 
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    this.faction = value;
                }
                else 
                {
                    this.faction = "Spellcaster";
                    Console.WriteLine("Inappropriate faction! Should be \"Melee\" or \"Spellcaster\"");
                }
            }
        }
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "no name";
                    Console.WriteLine("The name is too short or too long. Must be between 2 and 10 characters long.");
                }
            }
        }

        public int AbilityPoints 
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 0;  
                    Console.WriteLine("Inappropriate value! The ability points must be between 0 and 10.");
                }
            }
        }
        public int HealthPoints 
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    this.healthPoints = 0;
                    Console.WriteLine("Inappropriate value! The health points must be between 0 and 120.");
                }
            }
        }
        public int Level 
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    this.level = 0;
                    Console.WriteLine("Inappropriate value! Level must be between 0 and 100.");
                }
            }
        }

        public Chainlink BodyArmor 
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Axe Weapon 
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Warrior()
        {
            this.Name = "Bob";
            this.Level = level;
            this.HealthPoints = 1;
            this.Faction = "Melee";
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public Warrior(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = 100;
            this.Faction = "Melee";
            this.AbilityPoints = 10;
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public Warrior(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = 100;
            this.Faction = "Melee";
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}