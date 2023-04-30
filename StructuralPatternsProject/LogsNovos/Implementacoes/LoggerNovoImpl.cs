using System;

namespace DesignPatterns
{
    // Target class
    public class LoggerNovoImpl : ILoggerNovo
    {
        public string LogInfoNovo(string message)
        {
            return $"{DateTime.Now} LogInfo Novo - {message}";
        }

        public string LogErrorNovo(Exception exception)
        {
            return $"{DateTime.Now} LogError Novo - {exception.Message}";
        }
    }
}