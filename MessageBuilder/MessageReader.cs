using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBuilder
{
    public class MessageReader : IMessageReader
    {
        JsonSerializer jsonSerializer;
        List<MessageHandler> messages = new List<MessageHandler>();

        public MessageReader()
        {
            jsonSerializer = new JsonSerializer();
            jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        }


        public List<MessageHandler> ReadMessages()
        {
            FileChecker.CreateFile();

            using (StreamReader sr = new StreamReader(FileChecker.filepath))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    messages = jsonSerializer.Deserialize<List<MessageHandler>>(reader);
                    if (messages is null)
                        messages = new List<MessageHandler>();
                    if (messages.Count>0 &&
                        messages[messages.Count - 1].MessageCode != "-1")
                    {
                        messages.Add(new MessageHandler()
                        {
                            MessageCode = "-1",
                            MessageType = MessageTypes.NORMAL
                        });
                    }
                    return messages;
                }
            }
        }
    }
}
