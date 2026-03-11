namespace DependencyInjection1
{
    interface IWyjscie
    {
        void zapisz(string wiadomosc);
    }

    class WyjscieKonsola : IWyjscie
    {
        public void zapisz(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }
    }
    class WyjsciePlik : IWyjscie
    {
        public void zapisz(string wiadomosc)
        {
            //zapisywanie do pliku
        }
    }
    class Kalkulator(IWyjscie wyjscie)
    {
        public void Dodaj(int a, int b)
        {
            int suma = a + b;
            wyjscie.zapisz(suma.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Sklep(ITransakcja transakcja, IRabat rabat)
    {
        private string produkt;
        string cena;

    }

    internal interface ITransakcja
    {
        void dokonajTransakcji();
    }

    internal interface IRabat
    {
        float nalozRabat(float a);
    }

    class RabatDefault : IRabat
    {
        public float nalozRabat(float a)
        {
            return a * 0.9f;
        }
    }
    class RabatRodzinny: IRabat
    {
        public float nalozRabat(float a)
        {
            return a * 0.77f;
        }
    }
}




// na kartkowce bedzie to



namespace PureDIExample
{
    public interface ILogger
    {
        void Log(string text);
    }

    
    public interface IEmailService
    {
        void Send(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }

    class EmailService : IEmailService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    class UserService
    {
        private readonly ILogger _logger;
        private readonly IEmailService _email;

        public UserService(ILogger logger, IEmailService email)
        {
            _logger = logger;
            _email = email;
        }

        public void CreateUser()
        {
            _logger.Log("User created");
            _email.Send("Welcome!");
        }
    }

    class Program
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            IEmailService email = new EmailService();

            UserService userService = new UserService(logger, email);

            userService.CreateUser();
        }
    }
    

}


