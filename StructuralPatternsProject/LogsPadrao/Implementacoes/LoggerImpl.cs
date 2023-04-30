using System;

namespace DesignPatterns
{
    // Target class
    public class LoggerImpl : ILogger
    {
        public string LogInfo(string message)
        {
            return $"LogInfo Padrao - {message}";
        }

        public string LogError(Exception exception)
        {
            return $"LogError Padrao - {exception.Message}";
        }
    }
}