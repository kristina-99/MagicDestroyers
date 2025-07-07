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
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();
        
        public Warrior()
            : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.ABILITY_POINTS)
        {
        }

        public Warrior(string name, int level, int abilityPoints)
            : base(name,level,abilityPoints)
        {
            base.HealthPoints = Consts.Warrior.HEALTH_POINTS;
            base.Faction = Consts.Warrior.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Strike()
        {
            return base.Weapon.Damage + 10;
        }

        public int Execute()
        {
            return base.Weapon.Damage + 15;
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