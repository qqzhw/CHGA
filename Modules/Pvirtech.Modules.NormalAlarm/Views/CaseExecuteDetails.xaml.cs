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
    /// CaseExecuteDetails.xaml 的交互逻辑
    /// </summary>
    public partial class CaseExecuteDetails : UserControl
    {
        public CaseExecuteDetails()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (this.spOne.Visibility == Visibility.Visible)
            {
                this.spOne.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.spOne.Visibility = Visibility.Visible;
            }
        }
    }
}
