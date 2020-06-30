using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShellMeter.Utility
{
    static class Alerts
    {
        public static void ShowUnknowError(Exception e)
        {
            MessageBox.Show($"Неизвестная ошибка {e}");
        }

        public static void ConnectionError()
        {
            MessageBox.Show("Необходимо подключиться к устройству");
        }
    }
}
