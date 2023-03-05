using ClassGameRPG;

namespace ClassGameRPG;


public class Mage : Unit
{
    
    public override int DamagePlayer { get; set; } = 100;
    public override int HealthPlayer { get; set; } = 70;
    private double ArmorPenetration { get; set; } = 40;

    public override void Attack()
    {
        Console.WriteLine("Mage deals damage = " + (DamagePlayer - (EnemyResistance - ArmorPenetration)) + ".   And received damage = " + DamageEnemy + ".  Current Health Enemy = " + (CurrentHealth - DamagePlayer));
    }
}