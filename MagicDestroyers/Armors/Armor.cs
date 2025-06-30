using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armors
{
    public class Armor
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
    }
}
