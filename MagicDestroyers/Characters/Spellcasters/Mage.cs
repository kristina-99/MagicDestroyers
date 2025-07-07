namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    using MagicDestroyers.Armors.Cloth;
    using MagicDestroyers.Characters.Enumerations;
    using MagicDestroyers.Weapons.Blunt;

    public class Mage : Spellcaster
    {
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage()
            : this(Consts.Mage.NAME, Consts.Mage.LEVEL)
        {

        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.MANA_POINTS)
        {

        }

        public Mage(string name, int level, int manaPoints)
            : base(name,level,manaPoints)
        {
            base.HealthPoints = Consts.Mage.HEALTH_POINTS;
            base.Faction = Consts.Mage.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ArcaneWrath()
        {
            return base.Weapon.Damage + 10;
        }

        public int Fireball()
        {
            return base.Weapon.Damage + 15;
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}

