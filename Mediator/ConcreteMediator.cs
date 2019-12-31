using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mediator;

namespace DesignPatterns.Mediator
{
    public class ConcreteMediator : Mediator
    {
//        public Colleague1 Colleague1 { get; set; }
//        
//        public Colleague2 Colleague2 { get; set; }

        private IList<Colleague> colleagues = new List<Colleague>();
        
        public T CreateColleague<T>() where T : Colleague, new ()
        {
            var colleague = new T();
            colleague.SetMediator(this);
            colleagues.Add(colleague);
            return colleague;
        }

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            colleagues.Add(colleague);
        }
        public override void Send(string message, Colleague colleague) => 
            colleagues.Where(col => col == colleague).ToList()
                .ForEach(coll => coll.HandleNotification(message));
    }
}