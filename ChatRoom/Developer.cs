using System;

namespace ChatRoom
{
    public class Developer : Team
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{Name} has sent {message}"); 
        }

        public Developer(string name) : base(name)
        {
        }
    }
}