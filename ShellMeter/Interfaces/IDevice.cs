using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter.BL
{
    interface IDevice
    {
        Status ConnectionStatus { get; }
        ConnectToDevice(string pName);
        string[] GetPortNames();
        List<MeasureResults> MeasureResults { get; }
        void SaveSettings();
    }
}
