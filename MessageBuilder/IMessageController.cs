using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBuilder
{
    interface IMessageController
    {
        void ShowMessage(IMessageHandler message, string system_param);
    }
}
