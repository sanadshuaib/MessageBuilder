using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace MessageBuilder
{
    public class MessageWriter:IMessageWriter
    {
        JsonSerializer jsonSerializer;
        MessageHandler message;
        List<MessageHandler> messages;

        public MessageWriter(MessageHandler message, List<MessageHandler> messages)
        {
            jsonSerializer = new JsonSerializer();
            jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

            this.message = message;
            this.messages = messages;
        }

        public MessageWriter(List<MessageHandler> messages)
        {
            jsonSerializer = new JsonSerializer();
            jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

            this.messages = messages;
        }

        /// <summary>
        /// Takes the last message and add it to the previous list of messages
        /// </summary>
        public void WriteMessages()
        {
            FileChecker.CreateFile();

            using (StreamWriter sw = new StreamWriter(FileChecker.filepath))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    if (messages is null)
                        messages = new List<MessageHandler>();
                    messages.Add(message);
                    messages.RemoveAll(x => x.MessageCode == "-1");
                    if (messages.Count > 0)
                        sw.Write(JsonConvert.SerializeObject(messages, Formatting.Indented));
                    sw.Close();
                }
            }
        }

        /// <summary>
        /// Write all the messages in the message list at once
        /// </summary>
        public void WriteMessagesAtOnce()
        {
            FileChecker.CreateFile();

            using (StreamWriter sw = new StreamWriter(FileChecker.filepath))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    if (messages is null)
                        messages = new List<MessageHandler>();
                    messages.RemoveAll(x => x.MessageCode == "-1");
                    if (messages.Count>0)
                        sw.Write(JsonConvert.SerializeObject(messages, Formatting.Indented));
                    sw.Close();
                }
            }
        }
    }
}
