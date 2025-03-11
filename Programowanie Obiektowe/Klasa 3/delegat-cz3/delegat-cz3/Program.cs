namespace ConsoleApp1;

class Program
{
    public delegate void NotificationHandler(string message);

    public class User
    {
        public string Name { get; set; }
        public int Priority { get; set; } // 1 - wysoki 2 - sredni 3 - niski
    }
    public interface INotifier
    {
        void Notify(string message);
    }

    public class emailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"email wysłany: {message}");
        }
    }
    public class smsNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS wysłany: {message}");
        }
    }
    public class pushNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"powiadomienie push wysłane: {message}");
        }
    }

    public class NotificationManager
    {
        public NotificationHandler Notify;
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private List<INotifier> notifiers = new List<INotifier>();

        public void addUser(string name, int priority)
        {
            if (!users.ContainsKey(name))
            {
                users[name] = new User() { Name = name, Priority = priority };
                Console.WriteLine($"Dodano użytkownika {name} z priozytetem {priority}");
            }
            else
            {
                Console.WriteLine($"użytkownik o nazwie {name} już istnieje");
            }
            
        }

        public void removeUser(string name)
        {
            if (users.ContainsKey(name))
            {
                users.Remove(name);
                Console.WriteLine($"Usunięto użytkownika {name}");
            }
            else
            {
                Console.WriteLine($"Użytkownik {name} nie istnieje");
            }
        }

        public User getUserByName(string name)
        {
            if (users.TryGetValue(name, out var user))
            {
                return user;
            }
            return null;
        }

        public void ListUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("brak uzytkownikow");
                return;
            }
            Console.WriteLine("lista uzytkownikow:");
            int index = 1;
            foreach (var user in users)
            {
                Console.WriteLine($"{index} {user.Value.Name} (priorytet: {user.Value.Priority})");
                index++;
            }
        }

        public void sendNotification(string message, int priority)
        {
            if (notifiers.Count == 0)
            {
                Console.WriteLine("brak dostepnych metod powiadomien");
            }

            var filteredUsers = new List<User>(users.Values).FindAll(u => u.Priority <= priority);
            if (filteredUsers.Count == 0)
            {
                Console.WriteLine($"brak uzytkownikow z priorytetem równym lub najwyzszym niż {priority}");
                return;
            }

            Console.WriteLine($"wiadomość: \"{message}\"");
            foreach (var notifier in notifiers)
            {
                notifier.Notify(message);
            }

            Console.WriteLine("Powiadomienie zostało wysłane do:");
            foreach (var user in filteredUsers)
            {
                Console.WriteLine($"- {user.Name} (priorytet: {user.Priority})");
            }
        }

        public void addNotifier(INotifier notifier)
        {
            if (!notifiers.Contains(notifier))
            {
                notifiers.Add(notifier);
                Console.WriteLine("metoda powiadomienia została dodana");
            }
            else
            {
                Console.WriteLine("ta metoda powiadomienia już istnieje");
            }
        }
        
        public void removeNotifier(INotifier notifier)
        {
            if (notifiers.Remove(notifier))
            {
                Console.WriteLine("metoda powiadomienia została usunięta");
            }
            else
            {
                Console.WriteLine("Nie znaleziono tej metody powiadomienia");
            }
        }

        public void ListNotifiers()
        {
            if (notifiers.Count == 0)
            {
                Console.WriteLine("Brak dostępnych metod powiadomień");
                return;
            }

            Console.WriteLine("dostępne metody powiadomienia: ");
            foreach (var notifier in notifiers)
            {
                Console.WriteLine(notifier.GetType().Name);
            }
        }
    }
    
    static void Main(string[] args)
		{
			var notificationManager = new NotificationManager();

        var emailNotifier = new emailNotifier();
        var smsNotifier = new smsNotifier();
        var pushNotifier = new pushNotifier();

			while (true)
			{
				Console.WriteLine("\nMenu");
				Console.WriteLine("1. Dodaj użytkownika");
				Console.WriteLine("2. Usuń użytkownika");
				Console.WriteLine("3. Wyślij powiadomienie do użytkownika");
				Console.WriteLine("4. Wyświetl użytkowników");
				Console.WriteLine("5. Dodaj metodę powiadomień");
				Console.WriteLine("6. Usuń metodę powiadomień");
				Console.WriteLine("7. Wyświetl metody powiadomień");
				Console.WriteLine("8. Wyjdź");

            Console.WriteLine("\n Wybierz opcję:");
				var choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
                        Console.Write("Podaj imię użytkownika: ");
						string name = Console.ReadLine();

						int priority = GetValidPriority("Podaj priorytet użytkownika (liczba całkowita od 1 do 3: ");
                        notificationManager.AddUser(name, priority);
						break;
					case "2":
                        Console.Write("Podaj imię użytkownika, którego chcesz usunąć: ");
						notificationManager.RemoveUser(Console.ReadLine());
                        break;
					case "3":
                        Console.Write("Wpisz swoją wiadomość: ");
                        string message = Console.ReadLine();

                        priority = GetValidPriority("Podaj priorytet użytkowników, do których będzie wysłana wiadomość (liczba całkowita od 1 do 3: ");
						notificationManager.SendNotification(message, priority);
						break;
					case "4":
						notificationManager.ListUsers();
                        break;
					case "5":
                        Console.WriteLine("Wybierz metodę powiadamiania: ");
                        Console.WriteLine("\t1. Email");
                        Console.WriteLine("\t2. SMS");
                        Console.WriteLine("\t3. Powiadomienie PUSH");

                        Console.Write("\nWyberz opcję: ");
						choice = Console.ReadLine();
						switch (choice)
						{
							case "1":
								notificationManager.AddNotifier(emailNotifier);
								break;
							case "2":
								notificationManager.AddNotifier(smsNotifier);
								break;
							case "3":
								notificationManager.AddNotifier(pushNotifier);
								break;
							default:
                                Console.WriteLine("Nieprawidłowy wybór. Naciśnij dowolny klawisz");
								Console.ReadKey();
								break;
                        }
						break;
					case "6":
                        Console.WriteLine("Wybierz metodę powiadamiania do usunięcia: ");
                        Console.WriteLine("\t1. Email");
                        Console.WriteLine("\t2. SMS");
                        Console.WriteLine("\t3. Powiadomienie PUSH");

                        Console.Write("\nWyberz opcję: ");
                        choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                notificationManager.RemoveNotifier(emailNotifier);
                                break;
                            case "2":
                                notificationManager.RemoveNotifier(smsNotifier);
                                break;
                            case "3":
                                notificationManager.RemoveNotifier(pushNotifier);
                                break;
                            default:
                                Console.WriteLine("Nieprawidłowy wybór. Naciśnij dowolny klawisz");
                                Console.ReadKey();
                                break;
                        }
                        break;
					case "7":
						notificationManager.ListNotifiers();
                        break;
					case "8":
						return;
					default:
                        Console.WriteLine("Błędne dane. Wybierz poprawną opcję");
						break;
                }
			}
		}
        private static int GetValidPriority(string prompt)
        {
            while (true)
			{
                Console.Write(prompt);
				if (int.TryParse(Console.ReadLine(), out int result) && result >= 1 && result <= 3)
				{
					return result;
				}
				else
				{
                    Console.WriteLine("Błędne dane. Spróbuj ponownie\n");
                }
            }
        }
}