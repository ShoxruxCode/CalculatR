using System;
using System.IO;

namespace CalculatR.Classes
{
    public class LoggerBroker : ILoggerBroker
    {
        private readonly string logFilePath = "Logs/error.log";

        private void LogError(string message)
        {
            try
            {
                if (!File.Exists(logFilePath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
                    File.Create(logFilePath).Close();
                }
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log fayliga yozishda xatolik: " + ex.Message);
            }
        }

        public void LogException(Exception ex)
        {
            string errorMessage = $"Exception: {ex.GetType().Name}, Message: {ex.Message}, StackTrace: {ex.StackTrace}";
            LogError(errorMessage);
        }

        public void LogFileNotFound(string filePath)
        {
            string message = $"Fayl topilmadi: {filePath}";
            LogError(message);
        }

        public void LogFileAccessError(string filePath, Exception ex)
        {
            string message = $"Faylga kirishda xatolik: {filePath}, Exception: {ex.Message}";
            LogError(message);
        }

        public void LogGeneralError(string message)
        {
            LogError(message);
        }

        public void LogDataNotFound(string name, string lastName)
        {
            string message = $"Kontakt topilmadi: {name} {lastName}";
            LogError(message);
        }
    }
}