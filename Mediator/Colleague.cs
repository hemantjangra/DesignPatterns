using System;
using System.Collections;

namespace Mediator
{
    public abstract class Colleague
    {
        private DesignPatterns.Mediator.Mediator _mediator;
        
//        public Colleague(Mediator mediator)
//        {
//            _mediator = mediator;
//        }

        internal void SetMediator(DesignPatterns.Mediator.Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }

    public class Colleague1 : Colleague
    {
//        public Colleague1(Mediator mediator) : base(mediator)
//        {
//        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 received message { message }");
        }
    }

    public class Colleague2 : Colleague
    {
//        public Colleague2(Mediator mediator) : base(mediator)
//        {
//        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 received message { message }");
        }
    }
}