using System;

namespace ChatRoom
{
    public class Tester : Team
    {
        public Tester(string name) : base(name)
        {
            
        }
        
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{Name} has send {message}");
        }

        
    }
}