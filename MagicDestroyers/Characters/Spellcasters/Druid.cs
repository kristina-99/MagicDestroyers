namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Blunt;

    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Melee;

        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LeatherVest bodyArmor;
        private Staff weapon;

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
        public Staff Weapon 
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

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Druid(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {

        }

        public Druid(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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

