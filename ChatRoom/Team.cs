using System;

namespace ChatRoom
{
    public abstract class Team
    {
        private Room _room;
        
        public string Name { get; set; }

        protected Team(string name)
        {
            Name = name;
        }

        public void SetMediator(Room room)
        {
            _room = room;
        }
        public virtual void Send(string message)
        {
            _room.Send(message);
        }
        public abstract void HandleNotification(string message);

        public virtual void SendTo<T>(string message) where T : Team
        {
            _room.SendTo<T>(message);
        }
    }
}