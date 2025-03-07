namespace GoF.DesignPatterns.Adapter;

internal static class Program
{
    private static void Main(string[] args)
    {
        var legacyLogger = new LoggingAdapter(new OldLoggingSystem());
        legacyLogger.Log("This message will be logged");
        
        var newLogger = new NewLoggingSystem();
        newLogger.Log("This message will be logged");
    }
}