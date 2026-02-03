using System;
using System.Collections.Generic;
using System.IO;

namespace System_Rezerwacji_Zaglowek_Online.Patterns
{
    //Logger do logowania zdarzeń w systemie

    public sealed class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private readonly string _logFilePath;
        private readonly List<string> _logs;

        private Logger()
        {
            _logFilePath = "reservation_logs.txt";
            _logs = new List<string>();
            Log("System logowania zainicjowany");
        }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock)
                    {
                        if (_instance == null) _instance = new Logger();
                    }

                return _instance;
            }
        }

        public void Log(string message)
        {
            var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            _logs.Add(logEntry);
            //Console.WriteLine($"?? LOG: {logEntry}");

            try
            {
                File.AppendAllText(_logFilePath, logEntry + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"?? Błąd zapisu do pliku logu: {ex.Message}");
            }
        }

        public void DisplayAllLogs()
        {
            Console.WriteLine("\n╔═══════════════════════╗");
            Console.WriteLine("║    HISTORIA LOGÓW     ║");
            Console.WriteLine("╚═══════════════════════╝");
            foreach (var log in _logs) Console.WriteLine(log);
            Console.WriteLine();
        }

        public void ClearLogs()
        {
            _logs.Clear();
            try
            {
                File.WriteAllText(_logFilePath, string.Empty);
                Log("Logi zostały wyczyszczone");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"?? Błąd czyszczenia pliku logu: {ex.Message}");
            }
        }
    }
}