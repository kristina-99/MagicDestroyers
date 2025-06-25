using System;

namespace MagicDestroyers.Armors.Mail
{
    public class Chainlink
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.armorPoints = value;
                }
                else
                {
                    armorPoints = 0;
                    Console.WriteLine("Inappropriate value! The armor points must be between 0 and 100.");
                }
            }
        }

        public Chainlink()
        {

        }
    }
}