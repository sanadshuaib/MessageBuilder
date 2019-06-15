using System.Collections.Generic;

namespace MessageBuilder
{
    public interface IMessageReader
    {
        List<MessageHandler> ReadMessages();
    }
}