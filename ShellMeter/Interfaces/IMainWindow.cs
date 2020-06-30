using ShellMeter.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ShellMeter
{
    interface IMainWindow
    {
        void SetPortNamesList(string[] result);
        void ShowWindow();
        void CloseWindow();
        void ButtonChange(string text, SolidColorBrush color);
        void AppendLogIn();
        void AppendLogOut();
        event EventHandler ConnectToDeviceClick;
        event EventHandler StartProcessClick;
        event EventHandler SettingClick;
        event EventHandler ExportClick;
        event EventHandler ExitClick;
    }
}
