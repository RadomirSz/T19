using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    internal class Program
    {

        public delegate void NotificationHandler(string message);

        public class EmailNotifier
        {
            public void SendEmail(string message)
            {
                Console.WriteLine($"email wyslany: {message}");
            }
        }

        public class SMSNotifier
        {
            public void SendSMS(string message)
            {
                Console.WriteLine($"sms wyslany: {message}");
            }
        }

        public class PushNotifier
        {
            public void SendPushNotifier(string message)
            {
                Console.WriteLine($"powiadomienie wysłane: {message}");
            }
        }

        public class NotificationManager
        {
            public NotificationHandler Notify;

            public void AddNotificationMethod(NotificationHandler handler)
            {
                Notify += handler;
            }

            public void RemoveNotificationMethod(NotificationHandler handler)
            {
                Notify -= handler;
            }

            public void SendNotification(string message)
            {
                Notify?.Invoke(message);

            }


        }

        static void Main(string[] args)
        {
            var emailNotifier = new EmailNotifier();
            //emailNotifier.SendEmail("siema");
            var smsNotifier = new SMSNotifier();
            //smsNotifier.SendSMS("siema");
            var pushNotifier = new PushNotifier();
            //pushNotifier.SendPushNotifier("siema");

            var notificationMenager = new NotificationManager();

            notificationMenager.AddNotificationMethod(emailNotifier.SendEmail);
            notificationMenager.AddNotificationMethod(smsNotifier.SendSMS);
            notificationMenager.AddNotificationMethod(pushNotifier.SendPushNotifier);

            notificationMenager.SendNotification("1 wiadomość");
            
            Console.WriteLine();


            notificationMenager.RemoveNotificationMethod(smsNotifier.SendSMS);

            notificationMenager.SendNotification("2 wiadomość");

            Console.ReadKey();
        }

    }
}
