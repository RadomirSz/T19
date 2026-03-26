namespace SprawdzianRS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod paymentMethod = new BlikPayment();
            ISavingMethod savingMethod = new SaveToFile();

            SavingService savingService = new SavingService(savingMethod);
            PaymentService paymentService = new PaymentService(paymentMethod, savingService);

            paymentService.Pay();
        }

        class PaymentService
        {
            private IPaymentMethod _paymentMethod;
            private SavingService _savingService;

            public PaymentService(IPaymentMethod paymentMethod, SavingService savingService)
            {
                _paymentMethod = paymentMethod;
                _savingService = savingService;
            }

            public void Pay()
            {
                _paymentMethod.Pay();
                _savingService.Save();
            }
        }

        public interface IPaymentMethod
        {
            void Pay();
        }
        public class CardPayment : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("paying by Card");
            }
        }

        public class PaypalPayment : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("paying with Paypal");
            }
        }
        public class BlikPayment : IPaymentMethod
        {
            public void Pay()
            {
                Console.WriteLine("paying with Blik");
            }
        }

        class SavingService
        {
            private ISavingMethod _savingMethod;
            public SavingService(ISavingMethod savingMethod)
            {
                _savingMethod = savingMethod;
            }
            public void Save()
            {
                _savingMethod.Save();
            }
        }
        interface ISavingMethod
        {
            void Save();
        }
        public class SaveToFile : ISavingMethod
        {
            public void Save()
            {
                Console.WriteLine("Saving to file");
            }
        }
    }
}
