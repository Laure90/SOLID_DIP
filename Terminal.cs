using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Terminal : DataCommand
    {
        public Terminal()
        {
            _promptString = String.Format("{0}$ ", System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Exited = false;
        }
    }
}
