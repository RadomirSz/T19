namespace chainofresponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketResolver resolver = new TicketResolver();

            Ticket ticket1 = new Ticket("Password Reset", 1);
            Ticket ticket2 = new Ticket("Software Installation", 2);
            Ticket ticket3 = new Ticket("Network Issue", 3);
            resolver.Handler.HandleRequest(ticket1);
            resolver.Handler.HandleRequest(ticket2);
            resolver.Handler.HandleRequest(ticket3);
        }
    }


    public class Ticket(string name, int priority)
    {
        public string Name { get; } = name;
        public int Priority { get; } = priority;
    }

    public class TicketResolver
    {
        public SupportHandler Handler;
        public TicketResolver()
        {
            var levelOne = new LevelOneSupport();
            var levelTwo = new LevelTwoSupport();
            var levelThree = new LevelThreeSupport();
            levelOne.SetNext(levelTwo).SetNext(levelThree);
            Handler = levelOne;
        }
    }
    public abstract class SupportHandler
    {
        protected SupportHandler? NextHandler { get; private set; }
        public SupportHandler SetNext(SupportHandler handler)
        {
            NextHandler = handler;
            return handler;
        }
        public abstract void HandleRequest(Ticket ticket);
    }
    public class LevelOneSupport : SupportHandler
    {
        public override void HandleRequest(Ticket ticket)
        {
            if (ticket.Priority <= 1)
            {
                Console.WriteLine($"Level One Support resolved ticket: {ticket.Name}");
            }
            else
            {
                NextHandler?.HandleRequest(ticket);
            }
        }
    }
    public class LevelTwoSupport : SupportHandler
    {
        public override void HandleRequest(Ticket ticket)
        {
            if (ticket.Priority <= 2)
            {
                Console.WriteLine($"Level Two Support resolved ticket: {ticket.Name}");
            }
            else
            {
                NextHandler?.HandleRequest(ticket);
            }
        }
    }
    public class LevelThreeSupport : SupportHandler
    {
        public override void HandleRequest(Ticket ticket)
        {
            if (ticket.Priority <= 3)
            {
                Console.WriteLine($"Level Three Support resolved ticket: {ticket.Name}");
            }
            else
            {
                NextHandler?.HandleRequest(ticket);
            }
        }
    }
}
