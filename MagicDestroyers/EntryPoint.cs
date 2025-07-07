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
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellcaster = 0;

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
                currentMelee = rng.Next(0, meleeTeam.Count);
                currentSpellcaster = rng.Next(0, spellTeam.Count);

                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);


                if (!spellTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellcaster]);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }

                }

                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(), meleeTeam[currentSpellcaster].Name);


                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spell team wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }
            }
        }
    }
}
