using System;

namespace MagicDestroyers.Armors.Cloth
{
    public class ClothRobe
    {
        private int armorPoints;

        public int ArmorPoints 
        {
            get
            {
                return armorPoints;
            }
            set 
            {
                if (value >= 0 && value <= 100)
                {
                    armorPoints = value;
                }
                else
                {
                    armorPoints = 0;
                    Console.WriteLine("Inappropriate value! The armor points must be between 0 and 100.");
                }
            }    
        }

        public ClothRobe()
        {

        }
    }
}

