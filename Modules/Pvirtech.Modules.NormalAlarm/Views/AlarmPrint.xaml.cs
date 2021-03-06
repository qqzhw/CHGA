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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pvirtech.Modules.NormalAlarm.Views
{
    /// <summary>
    /// AlarmPrint.xaml 的交互逻辑
    /// </summary>
    public partial class AlarmPrint : UserControl
    {
        public AlarmPrint()
        {
            InitializeComponent();
            this.Loaded += AlarmPrint_Loaded;
        }

        void AlarmPrint_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = SystemParameters.PrimaryScreenHeight - 100;
        }
    }
}
