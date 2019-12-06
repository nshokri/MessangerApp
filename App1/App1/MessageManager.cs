using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class MessageManager
    {
        private List<UserMessage> pastMessages = new List<UserMessage>();

        public List<UserMessage> GetPastMessages()
        {
            return pastMessages;
        }
    }
}
