using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract class ChatMediator
    {
        public List<User> Users { get; set; } = new List<User>();

        public abstract void SendMessage(string message, string name, User user);
    }
}
