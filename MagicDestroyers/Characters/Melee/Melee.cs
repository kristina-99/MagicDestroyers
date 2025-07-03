namespace MagicDestroyers.Characters.Melee
{
    using System;

    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 0;
                    Console.WriteLine("Inappropriate value! The ability points must be between 0 and 10.");
                }
            }
        }

        public Melee(string name, int level, int abilityPoints)
            : base(name,level)
        {
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}
