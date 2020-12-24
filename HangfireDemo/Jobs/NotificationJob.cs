using System;
namespace HangfireDemo.Jobs
{
    public class NotificationJob
    {
        public void SendNotification()
        {
            Console.WriteLine(string.Format("New notification - {0}", DateTime.Now));  
        }
    }
}
