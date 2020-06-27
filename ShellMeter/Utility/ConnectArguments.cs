using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter
{
    class ConnectArguments : EventArgs
    {
        public object PortName{get;}

        public ConnectArguments(object pName)
        {
            PortName = pName;
        }
}
}
