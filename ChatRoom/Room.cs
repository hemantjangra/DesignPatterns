using System.Net.Sockets;

namespace ChatRoom
{
    public abstract class Room
    {
        public abstract void Send(string message);

        public abstract void Register(Team member);

        public abstract void SendTo<T>(string message) where T : Team;
    }
}