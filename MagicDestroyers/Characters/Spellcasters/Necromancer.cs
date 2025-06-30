namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Sharp;

    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
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

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {

        }

        public Necromancer(string name, int level, int manaPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.ManaPoints = manaPoints;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
