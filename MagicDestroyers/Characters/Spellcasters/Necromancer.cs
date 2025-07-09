namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Sharp;

    public class Necromancer : Spellcaster
    {
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer()
            : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.MANA_POINTS)
        {

        }

        public Necromancer(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = Consts.Necromancer.HEALTH_POINTS;
            base.Faction = Consts.Necromancer.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int ShadowRage()
        {
            return base.Weapon.Damage + 11;
        }

        public int VampireTouch()
        {
            return base.Weapon.Damage + 16;
        }

        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}
