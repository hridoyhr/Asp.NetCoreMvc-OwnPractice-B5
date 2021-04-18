using System;

namespace EventEx2
{
    class Program
    {
        public delegate void Notify(string address, string message);
        public event Notify Notification;

        static void Main(string[] args)
        {
            var instance = new Program();
            instance.Notification += EmailNotification;
            instance.Notification += SMSNotification;

            instance.Notification("mahmudl@gmail.com", "Hey I am Hridoy");

            instance.Notification -= EmailNotification;

            instance.Notification("01872944289", "Hi I am Hridoy");
        }

        private static void EmailNotification(string address, string message)
        {
            //Sending Email
            Console.WriteLine($"Sending Email to {address} with " +
                $"message: {message}");
        }

        private static void SMSNotification(string mobileNumber, string message)
        {
            Console.WriteLine($"Sending SMS to {mobileNumber} with message : {message}");
        }
    }
}
