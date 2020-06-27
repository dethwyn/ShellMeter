using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

            var result = device.GetPortNames();
            view.SetPortNamesList(result);
            view.ConnectToDeviceClick += View_ConnectToDeviceClick1;
        }

        private void View_ConnectToDeviceClick1(object sender, EventArgs e)
        {
            var args = (ConnectArguments)e;
            if (args.PortName != null)
            {
                var result = device.ConnectToDevice();
                if (result)
                {
                    view.Connect();
                }
                else
                {
                    view.Disconnect();
                }
            }
            else
            {
                MessageBox.Show("Please select device port");
            }
        }

        internal void Run()
        {

        }
    }
}
