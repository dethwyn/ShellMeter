using ShellMeter.BL;
using ShellMeter.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShellMeter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public event EventHandler ConnectToDeviceClick;
        public event EventHandler StartProcessClick;
        public event EventHandler SettingClick;
        public event EventHandler ExportClick;
        public event EventHandler ExitClick;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetButtonConnect()
        {
            btConnect.Content = "Connect";
            btConnect.Background = Brushes.Green;
        }

        private void BtConnect_Click(object sender, RoutedEventArgs e)
        {
            ConnectToDeviceClick(this, new ConnectArguments(cbPortNames.SelectedItem));
        }

        public void SetButtonDisconnect()
        {
            btConnect.Content = "Diconnect";
            btConnect.Background = Brushes.Red;
        }

        public void SetPortNamesList(string[] result)
        {
            foreach (var item in result)
            {
                cbPortNames.Items.Add(item);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetButtonDisconnect();
        }

        public void AppendLogIn()
        {
            throw new NotImplementedException();
        }

        public void AppendLogOut()
        {
            throw new NotImplementedException();
        }

        #region Show Window/Close Window
        public void ShowWindow()
        {
            Show();
        }

        public void CloseWindow()
        {
            Close();
        }
        #endregion

        #region Events
        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StartProcessClick(this, EventArgs.Empty);
            }
            catch (Exception exp)
            {
                Alerts.ShowUnknowError(exp);
            }
        }

        private void exportMenu_Click(object sender, RoutedEventArgs e)
        {
            ExportClick(this, EventArgs.Empty);
        }

        private void settingMenu_Click(object sender, RoutedEventArgs e)
        {
            SettingClick(this, EventArgs.Empty);
        }

        private void exitMenu_Click(object sender, RoutedEventArgs e)
        {
            ExitClick(this, EventArgs.Empty);
        }
        #endregion


    }
}
