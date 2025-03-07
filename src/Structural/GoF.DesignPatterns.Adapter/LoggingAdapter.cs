namespace GoF.DesignPatterns.Adapter;

public class OldLoggingSystem
{
    public void WriteLog(string logMessage)
    {
        Console.WriteLine($"Old logging system: {logMessage}");
    }
}

public interface ILogger
{
    void Log(string message);
}

public class NewLoggingSystem : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"New logging system: {message}");
    }
}

public class LoggingAdapter(OldLoggingSystem oldLoggingSystem) : ILogger
{
    public void Log(string message)
    {
        oldLoggingSystem.WriteLog(message);
    }
}