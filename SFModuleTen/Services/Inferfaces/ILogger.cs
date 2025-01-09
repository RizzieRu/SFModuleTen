namespace SFModuleTen.Services.Inferfaces;

public interface ILogger
{
    void LogEvent(string message);
    void LogError(string message);
}