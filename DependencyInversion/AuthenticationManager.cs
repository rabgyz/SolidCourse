using System;
namespace DependencyInversion
{
	public class AuthenticationManager
	{
		private INotificationSender notificationSender;
		public AuthenticationManager(INotificationSender notificationSender)
		{
			this.notificationSender = notificationSender;
		}

		public void Authenticate(User user, string email, string password)
		{
			if(user.Email == email && user.Password == password)
			{
				notificationSender.SendNotification(user);
				//EmailNotification emailNotification = new EmailNotification();
				//emailNotification.SendNotification(user);
				//if we need to change authentication method to f.e. SMSNotification, it's necessary to modify
				//AuthenticationManager class (high-level class). To prevent that, we gonna to invert dependencies.
			}
		}
	}
}

