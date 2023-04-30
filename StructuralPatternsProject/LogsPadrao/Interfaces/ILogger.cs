using System;

namespace DesignPatterns
{
    public interface ILogger
    {
        string LogInfo(string message);
        string LogError(Exception exception);
    }
}