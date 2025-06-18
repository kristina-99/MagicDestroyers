namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armors.Leather;
    using MagicDestroyers.Weapons.Sharp;
    public class Assassin
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private LeatherVest bodyArmor;
        private Sword weapon;

        public string Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public LeatherVest BodyArmor { get; set; }
        public Sword Weapon { get; set; }

        public Assassin()
        {

        }

        public void Raze()
        {

        }

        public void Bleed()
        {

        }

        public void Survival()
        {

        }
    }
}
