using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new ConcreteRoom();
            
            Developer ajit = new Developer("Ajit");
            Tester anotherAjit = new Tester("Another Ajit");
            Developer someAjit = new Developer("SomeAjit");
            chatroom.Register(ajit);
            chatroom.Register(anotherAjit);
            chatroom.Register(someAjit);
            ajit.Send("Will be working on this part");
            anotherAjit.Send("Will be working on another part");
            someAjit.SendTo<Developer>("This is developer to developer talk");
        }
    }
}