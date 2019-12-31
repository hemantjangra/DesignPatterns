using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ChatRoom
{
    public class ConcreteRoom : Room
    {
        private IList<Team> _teamMembers = new List<Team>();

        public override void Register(Team member)
        {
            _teamMembers.Add(member);
            member.SetMediator(this);
        }

        public override void SendTo<T>(string message)
        {
            _teamMembers.OfType<T>().ToList()
                .ForEach(mem => mem.HandleNotification(message));
        }

        public override void Send(string message)
        {
            _teamMembers.ToList().ForEach(mem => mem.HandleNotification(message));
        }
    }
}