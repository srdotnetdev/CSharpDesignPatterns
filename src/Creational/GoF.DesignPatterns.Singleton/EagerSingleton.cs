namespace GoF.DesignPatterns.Singleton;

public class EagerSingleton
{
    private static readonly  EagerSingleton EagerInstance = new();
    
    private EagerSingleton(){}
    
    public static EagerSingleton Instance => EagerInstance;
}