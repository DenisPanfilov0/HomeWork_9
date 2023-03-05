namespace ClassGameRPG;

public abstract class Unit
{
    
    public abstract int DamagePlayer { get; set; } 
    public abstract int HealthPlayer { get; set; }
    public double DamageEnemy { get; set; } 
    public double EnemyResistance { get; set; }
    
    
    public abstract void Attack();
    
    
}