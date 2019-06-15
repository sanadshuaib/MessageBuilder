using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBuilder
{
    public class MessageController : IMessageController
    {
        public void ShowMessage(IMessageHandler message, string system_param)
        {
            switch (message.MessageType)
            {
                case MessageTypes.NORMAL:
                    MessageBox.Show(message.MessageBody, message.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case MessageTypes.INFORMATION:
                    MessageBox.Show(message.MessageBody, message.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MessageTypes.ERROR:
                    MessageBox.Show(message.MessageBody+" : "+ system_param, message.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageTypes.CONFIRMATION:
                    MessageBox.Show(message.MessageBody, message.MessageTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    break;
                case MessageTypes.WARNING:
                    MessageBox.Show(message.MessageBody, message.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }
    }
}
