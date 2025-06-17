public class Warrior
{
    private string faction;
    private string name;

    private int abilityPoints;
    private int healthPoints;
    private int level;

    private Chainlink bodyArmor;
    private Axe weapon;

    public string Faction { get; set; }
    public string Name { get; set; }

    public int AbilityPoints { get; set; }
    public int HealthPoints { get; set; }
    public int Level { get; set; }

    public Chainlink BodyArmor { get; set; }
    public Axe Weapon { get; set; }
}
