using SFModuleTen.Services.Inferfaces;

namespace SFModuleTen.Services;

public class Logger : ILogger
{
    public void LogEvent(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"[EVENT]: {message}");
        Console.ResetColor();
    }

    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR]: {message}");
        Console.ResetColor();
    }
}