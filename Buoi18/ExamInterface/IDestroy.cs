namespace ExamInterface;

interface IDestroy
{
    // This interface defines a contract for classes that can be destroyed.
    // Classes implementing this interface must provide an implementation for the Destroy method.
    void Destroy();
    bool IsDestroyed { get; set; }
}
