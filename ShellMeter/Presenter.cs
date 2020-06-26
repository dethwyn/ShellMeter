using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellMeter.BL;

namespace ShellMeter
{
    class Presenter
    {
        IMainWindow mainWindow;
        IDevice device;

        public Presenter(IMainWindow window, IDevice device)
        {
            mainWindow = window;
            this.device = device;
        }
    }
}
