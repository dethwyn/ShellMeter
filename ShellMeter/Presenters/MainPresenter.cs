using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ShellMeter.BL;

namespace ShellMeter
{
    class MainPresenter
    {
        IMainWindow view;
        IDevice device;

        public MainPresenter(IMainWindow window, IDevice device)
        {
            view = window;
            this.device = device;

            var result = device.GetPortNames();
            view.ShowWindow();
            view.SetPortNamesList(result);
            view.ConnectToDeviceClick += View_ConnectToDeviceClick1;
            view.ExitClick += View_ExitClick;
        }

        private void View_ExitClick(object sender, EventArgs e)
        {
            view.CloseWindow();
        }

        private void View_ConnectToDeviceClick1(object sender, EventArgs e)
        {
            var args = (ConnectArguments)e;
            if (args.PortName != null)
            {
                device.ConnectToDevice(args.PortName.ToString());
                if (device.ConnectionStatus == Status.Connected)
                {
                    view.ButtonChange();
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
