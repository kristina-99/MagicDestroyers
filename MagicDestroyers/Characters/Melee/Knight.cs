namespace MagicDestroyers.Characters.Melee
{
    using System;
    using MagicDestroyers.Armors;
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons;
    using MagicDestroyers.Weapons.Blunt;

    public class Knight : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Knight()
            : this(Consts.Knight.NAME, Consts.Knight.LEVEL)
        {
        }

        public Knight(string name, int level)
            : this(name, level, Consts.Knight.ABILITY_POINTS)
        {
        }

        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = Consts.Knight.HEALTH_POINTS;
            base.Faction = Consts.Knight.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int HolyBlow()
        {
            return base.Weapon.Damage + 8;
        }

        public int PurifySoul()
        {
            return base.Weapon.Damage + 13;
        }

        public int RighteousWings()
        {
            return base.BodyArmor.ArmorPoints + 6;
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}