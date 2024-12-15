using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ConcreteChatMediator : ChatMediator
    {
        public override void SendMessage(string message, string name, User user)
        {
            User neededUser = Users
                .Where(u => u.Name == name)
                .SingleOrDefault();
            neededUser.recieveMessage(message, user.Name);
        }
    }
}
