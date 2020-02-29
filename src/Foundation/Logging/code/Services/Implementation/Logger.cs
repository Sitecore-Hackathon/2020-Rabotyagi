using System;
using Hackathon.Foundation.Logging.Services.Interfaces;
using Sitecore.Diagnostics;

namespace Hackathon.Foundation.Logging.Services.Implementation
{
    public class Logger : ILogger
    {
        public void Debug(string message)
        {
            Log.Debug(message, nameof(Logger));
        }

        public void Info(string message)
        {
            Log.Info(message, nameof(Logger));
        }

        public void Warn(string message)
        {
            Log.Warn(message, nameof(Logger));
        }

        public void Warn(string message, Exception exception)
        {
            Log.Warn(message, exception, nameof(Logger));
        }

        public void Error(string message)
        {
            Log.Error(message, nameof(Logger));
        }

        public void Error(string message, Exception exception)
        {
            Log.Error(message, exception, nameof(Logger));
        }
    }
}
