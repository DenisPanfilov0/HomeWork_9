using ClassGameRPG;
namespace ClassGameRPG;


public class Warrior : Unit
{

    public override int DamagePlayer { get; set; } = 80;
    public override int HealthPlayer { get; set; } = 120;
    private double ArmorPlayer { get; set; } = 35;
    private double DamageEnemy { get; set; } = 40;
    private double EnemyResistance { get; set; } = 50;

    
    public override void Attack()
    {
        Console.WriteLine("Warrior deals damage = " + (DamagePlayer - EnemyResistance) + ".   And received damage = " + (DamageEnemy - ArmorPlayer));
    }
}