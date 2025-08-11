namespace ExamInterface;

public interface IDamagable
{
    // This interface defines a contract for classes that can take damage.
    // Classes implementing this interface must provide an implementation for the TakeDamage method.
    public void TakeDamage(int amount);
    public int health { get; set; }
}

