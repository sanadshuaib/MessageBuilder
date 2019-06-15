using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBuilder
{
    public class MessageHandler : IMessageHandler
    {
        // Message code for example : 1-12
        public string MessageCode { get; set; }
        // Title for the message
        public string MessageTitle { get; set; }
        // Body of the message
        public string MessageBody { get; set; }
        // Type of message
        public MessageTypes MessageType { get; set; }
    }
}
