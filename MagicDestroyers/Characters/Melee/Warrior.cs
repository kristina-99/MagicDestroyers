namespace MagicDestroyers.Characters.Melee
{
    using System;
    using System.Collections.Generic;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Sharp;

    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private Chainlink bodyArmor;
        private Axe weapon;

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
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        {
        }

        public Warrior(string name, int level, int abilityPoints)
            : base(name,level,abilityPoints)
        {
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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