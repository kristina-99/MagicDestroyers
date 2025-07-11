﻿using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.manaPoints = value;
                }
                else
                {
                    this.manaPoints = 0;
                    Console.WriteLine("Inappropriate value! The mana points must be between 0 and 10.");
                }
            }
        }

        public Spellcaster(string name, int level, int manaPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
