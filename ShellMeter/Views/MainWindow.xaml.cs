using ShellMeter.BL;
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

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Connect()
        {
            btConnect.Content = "Connect";
            btConnect.Background = Brushes.Green;
        }

        private void BtConnect_Click(object sender, RoutedEventArgs e)
        {
            ConnectToDeviceClick(this, new ConnectArguments(cbPortNames.SelectedItem));
        }

        public void Disconnect()
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
            Disconnect();
        }

        public void AppendLogIn()
        {
            throw new NotImplementedException();
        }

        public void AppendLogOut()
        {
            throw new NotImplementedException();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            StartProcessClick(this, EventArgs.Empty);
        }
    }
}
