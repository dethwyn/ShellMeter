using ShellMeter.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter
{
    class SettingPresenter
    {
        IDevice model;
        ISettingView view;

        public SettingPresenter(IDevice device, ISettingView window)
        {
            model = device;
            view = window;
        }
    }
}
