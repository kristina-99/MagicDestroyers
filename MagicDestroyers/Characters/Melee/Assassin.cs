namespace MagicDestroyers.Characters.Melee
{
    using System;
    using System.Data;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Sharp;

    public class Assassin : Melee
    {
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Assassin()
            : this(Consts.Assasin.NAME, Consts.Assasin.LEVEL)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, Consts.Assasin.ABILITY_POINTS)
        {

        }

        public Assassin(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = Consts.Assasin.HEALTH_POINTS;
            base.Faction = Consts.Assasin.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int Raze()
        {
            return base.Weapon.Damage + 11;
        }

        public int Bleed()
        {
            return base.Weapon.Damage + 15;
        }

        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 4;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.Bleed();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }
}
