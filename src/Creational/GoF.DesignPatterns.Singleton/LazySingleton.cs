namespace GoF.DesignPatterns.Singleton;

public class LazySingleton
{
    private static readonly Lazy<LazySingleton> LazyInstance = new(() => new LazySingleton());
    
    private LazySingleton() { }
    
    public static LazySingleton Instance => LazyInstance.Value;
}