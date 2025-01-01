namespace GoF.DesignPatterns.Singleton;

public class BasicSingleton
{
    private static BasicSingleton? _instance;

    private BasicSingleton() { }

    public static BasicSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BasicSingleton();
            }
            return _instance;
        }
    }
}