using System;

namespace DesignPatterns
{
    public interface ILoggerNovo
    {
        string LogInfoNovo(string message);
        string LogErrorNovo(Exception exception);
    }
}