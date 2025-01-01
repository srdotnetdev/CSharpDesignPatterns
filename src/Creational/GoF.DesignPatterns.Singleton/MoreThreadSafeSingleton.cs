namespace GoF.DesignPatterns.Singleton;

public class MoreThreadSafeSingleton
{
    private static MoreThreadSafeSingleton? _instance;
    private static readonly object Lock = new();
    
    private MoreThreadSafeSingleton(){}

    public static MoreThreadSafeSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MoreThreadSafeSingleton();
                    }
                }
            }
            return _instance;
        }
    }
}