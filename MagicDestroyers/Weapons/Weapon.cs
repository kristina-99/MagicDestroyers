using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Weapons
{
    public class Weapon
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
    }
}
