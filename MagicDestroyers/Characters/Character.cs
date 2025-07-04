using System;
using MagicDestroyers.Armors;
using MagicDestroyers.Characters.Enumerations;
using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Weapons;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Factions faction;
        private string name;
        private int healthPoints;
        private int level;
        private Armor bodyArmor;
        private Weapon weapon;

        public Factions Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
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

        public Armor BodyArmor
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
        public Weapon Weapon
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

        public Character()
        { 
        
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public abstract void Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();
    }
}
