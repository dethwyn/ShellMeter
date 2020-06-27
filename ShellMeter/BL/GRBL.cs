using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter.BL
{
    public class GRBL
    {
        private double max_x;
        private double max_y;
        private double x;
        private double y;
        private SerialPort grblPort;

        public GRBL(double mX, double mY, string pName)
        {
            max_x = mX;
            max_y = mY;
            grblPort = new SerialPort(pName, 115200);
            x = 0;
            y = 0;
        }

        public bool GoHome()
        {
            return false;
        }

        public bool Connect()
        {
            return false;
        }

        public bool Disconnect()
        {
            return false;
        }

        public bool MoveToXY(double inX, double inY)
        {
            return false;
        }

    }
}
