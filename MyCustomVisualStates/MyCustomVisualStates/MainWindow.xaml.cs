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

namespace MyCustomVisualStates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(grid1, "State1", false);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(grid1, "State2", false);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(grid1, "State3", false);
        }
    }
}
