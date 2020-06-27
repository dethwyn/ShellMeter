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
        public double XMax { get; set; }
        public double YMax { get; set; }
        private double x;
        private double y;
        private SerialPort grblPort;

        public GRBL() { }

        public GRBL(double mX, double mY, string pName)
        {
            XMax = mX;
            YMax = mY;
            grblPort = new SerialPort(pName, 115200);
            x = 0;
            y = 0;
        }

        public bool GoHome()
        {
            return false;
        }

        public void Connect()
        {

        }

        public void Disconnect()
        {

        }

        public bool MoveToXY(double inX, double inY)
        {
            return false;
        }

    }
}
