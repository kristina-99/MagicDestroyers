namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Blunt;

    public class Druid : Spellcaster
    {
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Druid()
            : this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {

        }

        public Druid(string name, int level)
            : this(name, level, Consts.Druid.MANA_POINTS)
        {

        }

        public Druid(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = Consts.Druid.HEALTH_POINTS;
            base.Faction = Consts.Druid.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int Moonfire()
        {
            return base.Weapon.Damage + 9;
        }

        public int Starburst()
        {
            return base.Weapon.Damage + 13;
        }

        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints + 6;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}

