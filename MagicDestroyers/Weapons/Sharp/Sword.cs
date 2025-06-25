using System;

namespace MagicDestroyers.Weapons.Sharp
{
    public class Sword
    {
        private int damage;

        public int Damage 
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 0;
                    Console.WriteLine("Inappropriate value! The damage points must be between 0 and 50.");
                }
            }
        }

        public Sword()
        {

        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}

