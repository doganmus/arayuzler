using System;

namespace arayuzler
{
    public class LogManager:ILogger
    {
        public ILogger _logger; //interface in instance
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}