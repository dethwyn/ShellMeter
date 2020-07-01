using ShellMeter.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMeter
{
    class SettingArguments : EventArgs
    {
        Settings Settings { get; set; }
        public SettingArguments(Settings data)
        {
            Settings = data;
        }
    }
}
