﻿//namespace MagicDestroyers.Characters.Melee
//{
//    using System;
//    using MagicDestroyers.Armors;
//    using MagicDestroyers.Armors.Mail;
//    using MagicDestroyers.Characters.Enumerations;
//    using MagicDestroyers.Weapons;
//    using MagicDestroyers.Weapons.Blunt;

//    public class Knight : Melee
//    {
//        private const string DEFAULT_NAME = "Knight";
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_ABILITY_POINTS = 10;
//        private const int DEFAULT_HEALTH_POINTS = 100;
//        private const Factions DEFAULT_FACTION = Factions.Melee;

//        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
//        private readonly Hammer DEFAULT_WEAPON = new Hammer();

//        public Knight()
//            : this(DEFAULT_NAME, DEFAULT_LEVEL)
//        {
//        }

//        public Knight(string name, int level)
//            :this(name, level, DEFAULT_ABILITY_POINTS)
//        {
//        }

//        public Knight(string name, int level, int abilityPoints)
//            : base(name,level,abilityPoints)
//        {
//            base.HealthPoints = DEFAULT_HEALTH_POINTS;
//            base.Faction = DEFAULT_FACTION;
//            base.BodyArmor = DEFAULT_BODY_ARMOR;
//            base.Weapon = DEFAULT_WEAPON;
//        }

//        public void HolyBlow()
//        {
//            throw new NotImplementedException();
//        }

//        public void PurifySoul()
//        {
//            throw new NotImplementedException();
//        }

//        public void RighteousWings()
//        {
//            throw new NotImplementedException();
//        }

//        public override void Attack()
//        {
//            this.HolyBlow();
//        }

//        public override void SpecialAttack()
//        {
//            this.PurifySoul();
//        }

//        public override void Defend()
//        {
//            this.RighteousWings();
//        }
//    }
//}