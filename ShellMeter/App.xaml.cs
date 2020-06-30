using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ShellMeter.BL;
namespace ShellMeter
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            var window = new MainWindow();
            var device = new Device();
            var presenter = new MainPresenter(window, device);
            //window.Show();
        }
    }
}
