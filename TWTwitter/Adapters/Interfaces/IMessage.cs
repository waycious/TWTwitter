using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWTwitter.Data.Models;
using TWTwitter.Models;

namespace TWTwitter.Adapters.Interfaces
{
    public interface IMessage
    {
        List<MessageVM> GetMessages(string userId);
        void SendMessage(Message message);
    }
}
