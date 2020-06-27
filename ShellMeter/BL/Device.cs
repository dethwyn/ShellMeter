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

        public Status ConnectionStatus { get; private set; }

        public Device()
        {
            ConnectionStatus = Status.Disconnected;
        }

        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public bool ConnectToDevice()
        {
            if (ConnectionStatus == Status.Connected)
            {
                ConnectionStatus = Status.Disconnected;
                return false;
            }
            else
            {
                ConnectionStatus = Status.Connected;
                return true;
            }

        }
    }
}
