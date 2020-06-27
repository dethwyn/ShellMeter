using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace ShellMeter.BL
{
    public class Camera
    {
        public VideoCapture Capture { get; }
        public double Focus { get; }
        public double Distance { get; }
        public double MatrixWidth { get; }
        public double MatrixHeight { get; }

        public Camera(string url, double f, double d, double mw, double mh)
        {
            Capture = new VideoCapture(url);
            Focus = f;
            Distance = d;
            MatrixHeight = mh;
            MatrixWidth = mw;
        }

    }
}
