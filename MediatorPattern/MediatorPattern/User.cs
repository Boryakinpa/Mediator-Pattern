using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract class User
    {
        protected List<string> messages = new List<string>();
        protected ChatMediator? _mediator;

        public string Name { get; private set; }
        public abstract void sendMessage(string message, User user);
        public abstract void recieveMessage(string message, string name);

        public abstract void connectChat(ChatMediator mediator);
        public abstract void disconnectChat();

        public abstract void showHistory();

        public User(string name)
        {
            Name = name;
        }
    }
}
