using System;
namespace DependencyInversion
{
	public class SmsNotification : INotificationSender
	{
		public SmsNotification()
		{
		}

        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending sms notification to {user.Name}");
        }
    }
}

