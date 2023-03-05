using ClassGameRPG;
namespace ClassGameRPG;


public class Archer : Unit
{
    
    public override int DamagePlayer { get; set; } = 90;
    public override int HealthPlayer { get; set; } = 30;
    private double AttackSpeed { get; set; } = 1.8;
    private double DamageEnemy { get; set; } = 40;
    private double EnemyResistance { get; set; } = 50;
    
    public override void Attack()
    {
        Console.WriteLine("Archer deals damage = " + ((DamagePlayer * AttackSpeed) - EnemyResistance) + ".   And received damage = " + DamageEnemy);
    }
}