using System;
using DesignPatterns.Mediator;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();;
//            Colleague1 c1 = new Colleague1();
//            mediator.Register(c1);
//            Colleague2 c2 = new Colleague2();     call Create colleague as single statement instead of both
//            mediator.Register(c2);

//            mediator.Colleague1 = c1;
//            mediator.Colleague2 = c2;

            Colleague c1 = mediator.CreateColleague<Colleague1>();
            Colleague c2 = mediator.CreateColleague<Colleague2>();
            
            mediator.Send("a message", c1);
            mediator.Send("another message", c2);
        }
    }
}