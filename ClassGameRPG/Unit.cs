namespace ClassGameRPG;

public abstract class Unit
{
    
    public abstract int DamagePlayer { get; set; } 
    public abstract int HealthPlayer { get; set; }
    public double DamageEnemy { get; set; } = 40;
    public double EnemyResistance { get; set; } = 50;
    public double CurrentHealth = 200;
    
    
    public abstract void Attack();
    
    
}