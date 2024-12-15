using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ConcreteUser : User
    {
        public ConcreteUser(string name) : base(name) { }

        public override void sendMessage(string message, User user)
        {
            _mediator?.SendMessage(message, user.Name, this);
        }

        public override void recieveMessage(string message, string name)
        {
            Console.WriteLine($"{message} from {name}");
            messages.Add($"{message} from {name}");
        }

        public override void connectChat(ChatMediator mediator)
        {
            _mediator = mediator;
            _mediator.Users.Add(this);
        }

        public override void disconnectChat()
        {
            _mediator = null;
            messages.Clear();
        }

        public override void showHistory()
        {
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
