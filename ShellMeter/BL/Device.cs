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
        private Status connectionStatus;
        private Camera camera;

        public Status ConnectionStatus
        {
            get { return connectionStatus; }
        }

        public Device()
        {
            connectionStatus = Status.Disconnected;
        }

        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public bool ConnectToDevice()
        {
            if (ConnectionStatus == Status.Connected)
            {
                connectionStatus = Status.Disconnected;
                return false;
            }
            else
            {
                connectionStatus = Status.Connected;
                return true;
            }

        }
    }
}
