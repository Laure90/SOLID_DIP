using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public abstract class Dependences
    {
        public bool Exited { get; set; }

        public abstract Command PromptCommand();

        public abstract string Prompt();

        public abstract void ExecuteCommand(Command command);

    }
}
