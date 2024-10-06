using System;
namespace CalculatR.Classes
{
    public interface ILoggerBroker
    {
        void LogException(Exception ex);
        void LogFileNotFound(string filePath);
        void LogFileAccessError(string filePath, Exception ex);
        void LogGeneralError(string message);
        void LogDataNotFound(string name, string lastName);
    }
}