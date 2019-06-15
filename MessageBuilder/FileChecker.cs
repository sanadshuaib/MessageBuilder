using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace MessageBuilder
{
    public class FileChecker
    {
        public static string filepath = "";

        public static void CreateFile()
        {
            if (!File.Exists(filepath))
            {
                File.Create(filepath).Close();
            }
        }
    }
}
