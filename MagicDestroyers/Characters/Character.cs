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
        private bool isAlive;
        private int scores;

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

        public bool IsAlive
        {
            get 
            {
                return this.isAlive;
            }
            set 
            {
                this.isAlive = value;
            }
        }

        public int Scores
        {
            get 
            {
                return this.scores;
            }
            set 
            {
                this.scores = value;
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

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.IsAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.IsAlive)
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName} and is now dead!");
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName} and now has {this.healthPoints} health points left!");
            }
        }

        public void WonBattle()
        {
            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
