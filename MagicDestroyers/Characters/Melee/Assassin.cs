//namespace MagicDestroyers.Characters.Melee
//{
//    using System;
//    using System.Data;
//    using MagicDestroyers.Armors.Leather;
//    using MagicDestroyers.Characters.Enumerations;
//    using MagicDestroyers.Weapons.Sharp;

//    public class Assassin : Melee
//    {
//        private const string DEFAULT_NAME = "Assassin";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_ABILITY_POINTS = 10;
//        private const int DEFAULT_HEALTH_POINTS = 100;
//        private const Factions DEFAULT_FACTION = Factions.Melee;

//        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
//        private readonly Sword DEFAULT_WEAPON = new Sword();
   
//        public Assassin()
//            : this(DEFAULT_NAME, DEFAULT_LEVEL)
//        {

//        }

//        public Assassin(string name, int level)
//            : this(name, level, DEFAULT_ABILITY_POINTS)
//        { 
        
//        }

//        public Assassin(string name, int level, int abilityPoints)
//            : base(name,level,abilityPoints)
//        {
//            base.HealthPoints = DEFAULT_HEALTH_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODY_ARMOR;
//            base.Weapon = DEFAULT_WEAPON;
//        }

//        public void Raze()  
//        {
//            throw new NotImplementedException();
//        }

//        public void Bleed()
//        {
//            throw new NotImplementedException();
//        }

//        public void Survival()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            this.Raze();
//        }

//        public override void SpecialAttack()
//        {
//            this.Bleed();
//        }

//        public override void Defend()
//        {
//            this.Survival();
//        }
//    }
//}
