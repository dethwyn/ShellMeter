﻿using System;
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
using System.Windows.Shapes;

namespace ShellMeter
{
    /// <summary>
    /// Логика взаимодействия для ViewSettings.xaml
    /// </summary>
    public partial class ViewSettings : Window, ISettingView
    {
        public ViewSettings()
        {
            InitializeComponent();
            
        }

        public event EventHandler SaveSettingClick;

        public void CloseWindow()
        {
            Close();
        }

        public void ShowWindow()
        {
            Show();
        }
    }
}
