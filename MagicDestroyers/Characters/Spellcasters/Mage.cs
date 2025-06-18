namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armors.Cloth;
    using MagicDestroyers.Weapons.Blunt;
    public class Mage
    {
        private string faction;
        private string name;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private ClothRobe bodyArmor;
        private Staff weapon;

        public string Faction { get; set; }
        public string Name { get; set; }

        public int AbilityPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }

        public ClothRobe BodyArmor { get; set; }
        public Staff Weapon { get; set; }

        public Mage()
        {

        }

        public void ArcaneWrath()
        {

        }

        public void Firewall()
        {

        }

        public void Meditation()
        {

        }
    }
}

