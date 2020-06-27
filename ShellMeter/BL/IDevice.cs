using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter.BL
{
    enum Status
    {
        Connected,
        Disconnected
    }

    interface IDevice
    {
        Status ConnectionStatus { get; }
        bool ConnectToDevice(string pName);
        string[] GetPortNames();
        List<MeasureResults> MeasureResults { get; }

    }
}
