using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBuilder
{
    class TextChecker
    {
        public static ErrorProvider err = new ErrorProvider();

        public static bool TextIsEmpty(TextBox textbox)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                err.SetError(textbox, "Rquired");
                textbox.Focus();
                return true;
            }
            else
                err.Clear();
            return false;
        }
    }
}
