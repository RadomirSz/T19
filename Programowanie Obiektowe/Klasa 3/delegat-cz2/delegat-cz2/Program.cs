using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
                if (Notify == null)
                {
                    Console.WriteLine("brak dostępnych metod powiadomien");
                }
                Notify?.Invoke(message);


            }


        }

        public static void ShowMenu()
        {
            Console.WriteLine("menu");
            Console.WriteLine("1.dodaj powiadomienie email " +
                "\n2.dodaj powiadomienie sms " +
                "\n3.dodaj powiadomienie push" +
                "\n4.usun powiadomienie email" +
                "\n5.usun powiadomienie sms" +
                "\n6.usun powiadomienie push" +
                "\n7.wyslij powiadomienie" +
                "\n8.wyjdz");
                Console.Write("Wybierz opcję: ");

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

            //notificationMenager.AddNotificationMethod(emailNotifier.SendEmail);


            //notificationMenager.SendNotification("aa");


            while (true)
            {
                try
                {
                    ShowMenu();
                    var choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            notificationMenager.AddNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("dodano powiadomienie email");
                            break;
                        case 2:
                            notificationMenager.AddNotificationMethod(smsNotifier.SendSMS);
                            Console.WriteLine("dodano powiadomienie sms");
                            break;
                        case 3:
                            notificationMenager.AddNotificationMethod(pushNotifier.SendPushNotifier);
                            Console.WriteLine("dodano powiadomienie push");
                            break;
                        case 4:
                            notificationMenager.RemoveNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("usunieto powiadomienie email");
                            break;
                        case 5:
                            notificationMenager.RemoveNotificationMethod(smsNotifier.SendSMS);
                            Console.WriteLine("usunieto powiadomienie sms");
                            break;
                        case 6:
                            notificationMenager.RemoveNotificationMethod(pushNotifier.SendPushNotifier);
                            Console.WriteLine("usunieto powiadomienie push");
                            break;
                        case 7:
                            Console.WriteLine("podaj wiadomość:");
                            string message = Console.ReadLine();
                            notificationMenager.SendNotification(message);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("nieprawidłowa opcja, spróbuj ponownie");
                            break;
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



            Console.ReadKey();
        }

    }
}
