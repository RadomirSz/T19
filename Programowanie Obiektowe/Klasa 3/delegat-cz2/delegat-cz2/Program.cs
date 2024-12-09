using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _4_1_delegaty_menu
{
    internal class Program
    {
        public delegate void NotificationHandler(string message);

        public interface INotifier
        {
            void Notify(string message);

        }

        public class EmailNotifier : INotifier
        {
            public void Notify(string message)
            {
                try
                {
                    Console.WriteLine($"Email wysłany: {message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Błąd podczas wysyłania emaila: {ex.Message}");
                }
            }
        }

        public class SMSNotifier : INotifier
        {
            public void Notify(string message)
            {
                try
                {
                    Console.WriteLine($"SMS wysłany: {message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd podczas wysyłania SMS: {ex.Message}");
                }
            }
        }

        public class PushNotifier : INotifier
        {
            public void Notify(string message)
            {
                try
                {
                    Console.WriteLine($"Powiadomienie PUSH wysłane: {message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd podczas wysyłania powiadomienia push:{ex.Message}");
                }
            }
        }

        public class NotificationManager
        {
            public NotificationHandler Notify;

            public void AddNotificationMethod(NotificationHandler handler)
            {
                if (Notify != null && Notify.GetInvocationList().Contains(handler))
                {
                    Console.WriteLine("ta metoda powiadomienia jest już dodana");
                    return;
                }
                Notify += handler;
                Console.WriteLine("dodano metodę powiadomienia");
            }

            public void RemoveNotificationMethod(NotificationHandler handler)
            {
                if (Notify != null && Notify.GetInvocationList().Contains(handler))
                {
                    Notify -= handler;
                    Console.WriteLine("usunięto metodę powiadomienia");
                }
            }
            public void SendNotification(string message)
            {
                if (Notify == null)
                {
                    Console.WriteLine("Brak dostępnych metod powiadomień");
                    return;
                }
                foreach (var handler in Notify.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(message);
                        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Wysłano: {handler.Method.Name}, wiadomość: {message}{Environment.NewLine}";
                        File.AppendAllText("log.txt", logEntry);
                        
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"blad podczas wysylania powiadomienia: {ex.Message}");
                    }
                }
            }

            public void ListNotificationMethods()
            {
                if (Notify == null)
                {
                    Console.WriteLine("Brak dostępnych metod powiadomień");
                    return;
                }

                Console.WriteLine("zarejestrowane metody powiadomien:");

                var displayHandlers = new HashSet<string>();
                foreach (var handler in Notify.GetInvocationList())
                {
                    var target = handler.Target;
                    var methodName = handler.Method.Name;
                    var className = target?.GetType().Name ?? "nieznany";

                    var uniqueKey = $"{className}.{methodName}";
                    if (!displayHandlers.Contains(uniqueKey))
                    {
                        displayHandlers.Add(uniqueKey);
                        Console.WriteLine($" - Klasa: {className}, metoda: {methodName}");
                    }
                }
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Dodaj powiadomienie Email");
            Console.WriteLine("2. Dodaj powiadomienie SMS");
            Console.WriteLine("3. Dodaj powiadomienie Push");
            Console.WriteLine("4. Usuń powiadomienie Email");
            Console.WriteLine("5. Usuń powiadomienie SMS");
            Console.WriteLine("6. Usuń powiadomienie Push");
            Console.WriteLine("7. Wyślij powiadomienie");
            Console.WriteLine("8. Wyjdź");
            Console.Write("Wybierz opcję: ");
        }

        static void Main(string[] args)
        {

            //tworzenie instancji klas powiadomień
            var emailNotifier = new EmailNotifier();
            var smsNotifier = new SMSNotifier();
            var pushNotifier = new PushNotifier();

            //tworzenie instancji klasy NotificationManager
            var notificationManager = new NotificationManager();

            while (true)
            {
                try
                {
                    ShowMenu();
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            notificationManager.AddNotificationMethod(emailNotifier.Notify);
                            //Console.WriteLine("Dodano powiadomienie Email");
                            break;
                        case "2":
                            notificationManager.AddNotificationMethod(smsNotifier.Notify);
                            //Console.WriteLine("Dodano powiadomienie SMS");
                            break;
                        case "3":
                            notificationManager.AddNotificationMethod(pushNotifier.Notify);
                            //Console.WriteLine("Dodano powiadomienie Push");
                            break;
                        case "4":
                            notificationManager.RemoveNotificationMethod(emailNotifier.Notify);
                            Console.WriteLine("Usunięto powiadomienie Email");
                            break;
                        case "5":
                            notificationManager.RemoveNotificationMethod(smsNotifier.Notify);
                            Console.WriteLine("Usunięto powiadomienie SMS");
                            break;
                        case "6":
                            notificationManager.RemoveNotificationMethod(pushNotifier.Notify);
                            Console.WriteLine("Usunięto powiadomienie Push");
                            break;
                        case "7":
                            Console.Write("Wpisz wiadomość do wysłania: ");
                            var message = Console.ReadLine();
                            notificationManager.SendNotification(message);
                            break;
                        case "8":
                            return;
                        default:
                            Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wystąpił błąd: {e.Message}");
                }
            }
        }
    }
}