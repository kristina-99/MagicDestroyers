namespace MagicDestroyers.Characters.Melee
{
    using System;

    public class Melee : Character
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
    }
}
