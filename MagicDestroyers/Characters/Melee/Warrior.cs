namespace MagicDestroyers.Characters.Melee
{
    using System;
    using System.Collections.Generic;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Characters.Interfaces;
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
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int Strike()
        {
            return base.Weapon.Damage + 10;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}