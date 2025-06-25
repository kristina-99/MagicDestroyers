using System;

namespace MagicDestroyers.Weapons.Blunt
{
    public class Hammer
    {
        private int damage;

        public int Damage 
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    damage = value;
                }
                else
                {
                    damage = 0;
                    Console.WriteLine("Inappropriate value! The damage points must be between 0 and 50.");
                }
            }
        }
       
        public Hammer()
        {

        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}

