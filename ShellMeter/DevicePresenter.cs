using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellMeter.BL;

namespace ShellMeter
{
    class DevicePresenter
    {
        IMainWindow view;
        IDevice device;

        public DevicePresenter(IMainWindow window, IDevice device)
        {
            view = window;
            this.device = device;
        }

        internal void Run()
        {
            view.Show();
        }
    }
}
