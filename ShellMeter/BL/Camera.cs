using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Emgu.CV;

namespace ShellMeter.BL
{
    public class Camera
    {
        private VideoCapture capture;
        public string CameraURL { get; set; }
        public double Focus { get; set; }
        public double Distance { get; set; }
        public double MatrixWidth { get; set; }
        public double MatrixHeight { get; set; }

        public Camera() { }

        public Camera(string url, double f, double d, double mw, double mh)
        {
            capture = new VideoCapture(url);
            CameraURL = url;
            Distance = d;
            MatrixHeight = mh;
            MatrixWidth = mw;
        }

        public Mat GetFrame()
        {
            return new Mat();
        }
    }
}
