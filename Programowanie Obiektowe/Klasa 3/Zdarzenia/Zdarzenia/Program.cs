using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    public enum Role
    {
        Administrator,
        Manager,
        User
    }
    public enum Permission
    {
        Read,
        Write,
        Delete,
        ManageUsers
    }
    public class User
    {
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
        
        public User(string name)
        {
            this.Name = name;
            Roles = new List<Role>();
        }

        public void AddRole(Role role)
        {
            if (!Roles.Contains(role))
            {
                Roles.Add(role);
            }
        }
    }

    // role base access control
    public class RBAC
    {
        private readonly Dictionary<Role,List<Permission>> _rolePermissions;

        public RBAC()
        {
            _rolePermissions = new Dictionary<Role, List<Permission>>
            {
                {Role.Administrator, new List<Permission>{Permission.Read,Permission.Write,Permission.Delete} },
                {Role.Manager, new List<Permission>{Permission.Read,Permission.Write} },
                {Role.User, new List<Permission>{Permission.Read} }
            };
        }

        public bool HasPermission(User user, Permission permission)
        {
            foreach(var role in user.Roles)
            {
                if (_rolePermissions.ContainsKey(role) && _rolePermissions[role].Contains(permission))
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class PasswordManager
    {
        private const string passwordFilePath = "userPasswords.txt";
        public static event Action<string, bool> PasswordVerified;
        static PasswordManager()
        {
            if (!File.Exists(passwordFilePath))
            {
                File.Create(passwordFilePath).Dispose();
            }
        }

        public static void SavePassword(string username, string password)
        {
            if (File.ReadLines(passwordFilePath).Any(line => line.Split(',')[0] == username))
            {
                Console.WriteLine($"Użytkownik {username} już ustnieje w systemie");
                return;
            }

            string hashedPassword = HashPassword(password);
            File.AppendAllText(passwordFilePath, $"{username},{hashedPassword},\n");
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
            string hashedPassword = HashPassword(password);
            foreach (var line in File.ReadLines(passwordFilePath))
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
    class Program
    {
        static void Main(string[] args)
        {
            PasswordManager.PasswordVerified += (name, success) => Console.WriteLine
            ($"logowanie użytkownika {name}: {(success ? "udane":"nieudane")}");

            PasswordManager.SavePassword("xyz1", "pass");
            
            PasswordManager.SavePassword("admin", "pass");
            Console.WriteLine("daj nazwe użytkownika");
            string username = Console.ReadLine();

            Console.WriteLine("daj hasło");
            string password = Console.ReadLine();
            Console.WriteLine();

            if (!PasswordManager.VerifyPassword(username, password))
            {
                Console.WriteLine("niepoprawna nazwa użytkownika lub hasło");
                return;
            }

            var user = new User(username);
            if (username == "admin")
            {
                user.AddRole(Role.Administrator);
            }
            else if(username == "manager")
            {
                user.AddRole(Role.Manager);
            }
            else if(username == "normalUser")
            {
                user.AddRole(Role.User);
            }

            var rbacSystem = new RBAC();
            Console.WriteLine("sprawdzanie dostepu do roznych zasobow");
            Console.WriteLine("Read: " + rbacSystem.HasPermission(user,Permission.Read));
            Console.WriteLine("Write: " + rbacSystem.HasPermission(user, Permission.Write));
            Console.WriteLine("Delete: " + rbacSystem.HasPermission(user, Permission.Delete));
        }
    }
}
