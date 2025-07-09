using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers
{
    public static class Consts
    {
        public static class Warrior
        {
            public const string NAME = "Bob";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Melee;
        }

        public static class Assasin
        {
            public const string NAME = "Sam";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Melee;
        }

        public static class Knight
        {
            public const string NAME = "Arthur";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Melee;
        }

        public static class Mage
        {
            public const string NAME = "Merlin";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Spellcaster;
        }

        public static class Druid
        {
            public const string NAME = "River";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Spellcaster;
        }

        public static class Necromancer
        {
            public const string NAME = "Nec";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Spellcaster;
        }
    }
}
