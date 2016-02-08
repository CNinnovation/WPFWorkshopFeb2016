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
using System.Windows.Threading;

namespace EventSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var timer = new DispatcherTimer(DispatcherPriority.ApplicationIdle);
            timer.Tick += (sender, e) =>
            {
                angleRotate.Angle += 0.5;
            };
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.IsEnabled = true;
        }



        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            angleRotate.Angle += 1;
        }
    }
}
