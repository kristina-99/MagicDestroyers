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
            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                new Mage(),
                new Mage()
                //new Necromancer(),
                //new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                //1. take a random Melee
                //2. take a random Spellcaster

                spellTeam[0].TakeDamage(meleeTeam[0].Attack());

                //3. Melee attacks Spellcaster
                //3.1 Check if the character has died and remove him from the team
                //3.2 If the character has died pick another character from the team

                meleeTeam[0].TakeDamage(spellTeam[0].Attack());

                //4. Spellcaster attacks Melee
                //4.1 Check if the character has died and remove him from the team
                //4.2 If the character has died pick another character from the team

                //5. If no characters are alive from either team - gameOver = true
            }
        }
    }
}
