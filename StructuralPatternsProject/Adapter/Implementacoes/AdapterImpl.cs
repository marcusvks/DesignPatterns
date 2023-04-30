using DesignPatterns;
using System;

namespace StructuralPatternsProject
{
    public class AdapterImpl : ILogger
    {
        private readonly ILoggerNovo _loggerNovo;

        public AdapterImpl(ILoggerNovo loggerNovo)
        {
            _loggerNovo = loggerNovo;
        }

        public string LogError(Exception exception)
        {
            return _loggerNovo.LogErrorNovo(exception);
        }

        public string LogInfo(string message)
        {
            return _loggerNovo.LogInfoNovo(message);
        }
    }
}
