namespace MagicDestroyers.Characters.Melee
{
    using System;
    using System.Data;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Sharp;

    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Assassin";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LeatherVest bodyArmor;
        private Sword weapon;

        public LeatherVest BodyArmor
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
        public Sword Weapon
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

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)
        { 
        
        }

        public Assassin(string name, int level, int abilityPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = abilityPoints;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Raze()  
        {
            throw new NotImplementedException();
        }

        public void Bleed()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
