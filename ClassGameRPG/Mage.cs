using ClassGameRPG;

namespace ClassGameRPG;


public class Mage : Unit
{
    
    public override int DamagePlayer { get; set; } = 100;
    public override int HealthPlayer { get; set; } = 70;
    private double ArmorPenetration { get; set; } = 40;
    private double DamageEnemy { get; set; } = 40;
    private double EnemyResistance { get; set; } = 50;
    
    public override void Attack()
    {
        Console.WriteLine("Mage deals damage = " + (DamagePlayer - (EnemyResistance - ArmorPenetration)) + ".   And received damage = " + DamageEnemy);
    }
}