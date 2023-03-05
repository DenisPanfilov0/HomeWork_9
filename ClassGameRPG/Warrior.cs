using ClassGameRPG;
namespace ClassGameRPG;


public class Warrior : Unit
{

    public override int DamagePlayer { get; set; } = 80;
    public override int HealthPlayer { get; set; } = 120;
    private double ArmorPlayer { get; set; } = 35;
    
    
    public override void Attack()
    {
        Console.WriteLine("Warrior deals damage = " + (DamagePlayer - EnemyResistance) + ".   And received damage = " + (DamageEnemy - ArmorPlayer) + ".  Current Health Enemy = " + (CurrentHealth - DamagePlayer));
    }
}