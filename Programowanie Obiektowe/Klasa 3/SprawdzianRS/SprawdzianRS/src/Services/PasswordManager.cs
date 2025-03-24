using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SprawdzianRS.src.Services
{
    public class PasswordManager
    {
        private const string _passwordFilePath = "userPasswords.txt";

        static PasswordManager()
        {
            if (!File.Exists(_passwordFilePath)) File.Create(_passwordFilePath).Dispose();
        }

        public static event Action<string, bool> PasswordVerified;

        public static void SavePassword(string username, string password)
        {
            if (File.ReadLines(_passwordFilePath).Any(line => line.Split(',')[0] == username))
            {
                Console.WriteLine($"Użytkownik {username} już istnieje w systemie");
                return;
            }

            var hashedPassword = HashPassword(password);
            File.AppendAllText(_passwordFilePath, $"{username},{hashedPassword}\n");
            Console.WriteLine($"Użytkownik {username} został zapisany");
        }

        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public static bool VerifyPassword(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            foreach (var line in File.ReadLines(_passwordFilePath))
            {
                var parts = line.Split(',');
                if (parts[0] == username && parts[1] == hashedPassword)
                {
                    PasswordVerified?.Invoke(username, true);
                    return true;
                }
            }

            PasswordVerified?.Invoke(username, false);
            return false;
        }
    }
}