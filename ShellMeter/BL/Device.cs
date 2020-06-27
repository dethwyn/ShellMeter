using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ShellMeter.BL
{
    class Device : IDevice
    {
        private Camera camera;
        private GRBL grbl;

        public List<MeasureResults> MeasureResults { get; private set; }
        public Status ConnectionStatus { get; private set; }

        public Device()
        {
            ConnectionStatus = Status.Disconnected;
        }

        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public bool ConnectToDevice(string pName)
        {
            grbl = new GRBL(0, 0, pName);
            if (ConnectionStatus == Status.Connected)
            {
                ConnectionStatus = Status.Disconnected;
                grbl.Disconnect();
                return false;
            }
            else
            {
                ConnectionStatus = Status.Connected;
                grbl.Connect();
                return true;
            }
        }
    }
}
