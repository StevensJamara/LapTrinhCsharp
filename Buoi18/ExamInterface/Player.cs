namespace ExamInterface;

public class Player : IDamagable, IDestroy
{
    public bool IsDestroyed { get; set; } = false;
    public int health { get; set; }

    public Player(int initialHealth)
    {
        health = initialHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
            health = 0;
        Console.WriteLine($"Player took {amount} damage, remaining health: {Health}");
    }
    void Death()
    {
        if (health <= 0)
        {
            IsDestroyed = true;
            Destroy();
            Console.WriteLine("Player has died.");
        }
    }
    public int Health => health;

    //Detroy method from IDestroy interface
    public void Destroy()
    {
        IsDestroyed = true;
        Console.WriteLine("Player has been destroyed.");
    }
}

