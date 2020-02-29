using System;

namespace Hackathon.Foundation.Logging.Services.Interfaces
{
    public interface ILogger
    {
        void Debug(string message);
        void Info(string message);
        void Warn(string message);
        void Warn(string message, Exception exception);
        void Error(string message);
        void Error(string message, Exception exception);
    }
}
