using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Log
    {
        public static void save(Exception err)
        {
            StreamWriter sr = new StreamWriter("../../../log.txt", true, Encoding.ASCII);
            DateTime localDate = DateTime.Now;
            sr.WriteLine($"[{localDate.ToString()}] {err.Message} {err.StackTrace}");
            sr.Close();
        }
    }
}
