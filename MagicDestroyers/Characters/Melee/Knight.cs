namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armors.Mail;
    using MagicDestroyers.Weapons.Blunt;
    public class Knight
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Chainlink bodyArmor;
        private Hammer weapon;

        public string Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public Chainlink BodyArmor { get; set; }
        public Hammer Weapon { get; set; }

        public Knight()
        {

        }

        public void HolyBlow()
        {

        }

        public void PurifySoul()
        {

        }

        public void RighteousWings()
        {

        }
    }
}