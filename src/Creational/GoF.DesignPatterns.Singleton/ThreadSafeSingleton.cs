namespace GoF.DesignPatterns.Singleton;

public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton? _instance;
    private static readonly object Lock = new();
    
    private ThreadSafeSingleton(){}

    public static ThreadSafeSingleton Instance
    {
        get
        {
            lock (Lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                }
            }
            return _instance;
        }
    }
}