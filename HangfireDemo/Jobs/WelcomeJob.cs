using System;
namespace HangfireDemo.Jobs
{
    public class WelcomeJob
    {
        public void SendWelcome()
        {
            Console.WriteLine("Welcome!");
        }
    }
}
