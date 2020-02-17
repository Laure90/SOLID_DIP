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
            Terminal terminal = new Terminal();
            while (!terminal.Exited)
            {
                Command command = terminal.PromptCommand();
                terminal.ExecuteCommand(command);
            }
        }
    }
}

