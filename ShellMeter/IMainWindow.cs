using ShellMeter.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter
{
    interface IMainWindow
    {
        void SetPortNamesList(string[] result);
        void Connect();
        void Disconnect();
        void AppendLogIn();
        void AppendLogOut();
        event EventHandler ConnectToDeviceClick;
        event EventHandler StartProcessClick;
    }
}
