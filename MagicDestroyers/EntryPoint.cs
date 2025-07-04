using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Character warrior = new Warrior();
            Character knight = new Knight();
            Character assassin = new Assassin();
            Character mage = new Mage();
            Character necromancer = new Necromancer();
            Character druid = new Druid();

            List<Character> meleeTeam = new List<Character>();
            List<Character> spellTeam = new List<Character>();

            meleeTeam.Add(warrior);
            meleeTeam.Add(knight);
            meleeTeam.Add(assassin);

            spellTeam.Add(mage);
            spellTeam.Add(necromancer);
            spellTeam.Add(druid);

        }
    }
}
