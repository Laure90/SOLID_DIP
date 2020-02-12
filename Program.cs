using System;
using System.Linq;
using System.Diagnostics;
using System.IO;

namespace DIP
{
    public class Program
    {
        public static void Main()
        {
            DataCommand datacommand = new Terminal();
            while (!datacommand.Exited)
            {
                Command command = datacommand.PromptCommand();
                datacommand.ExecuteCommand(command);
            }
        }
    }



    
}
