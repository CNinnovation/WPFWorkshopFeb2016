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
            var timer = new DispatcherTimer(DispatcherPriority.Background);
            timer.Tick += (sender, e) =>
            {
                angleRotate.Angle += 0.5;
            };
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.IsEnabled = true;
        }

        private double _left = 20;

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            // angleRotate.Angle += 1;

            Canvas.SetLeft(button1, _left++);
            
            
        }

        private void OnGeo(object sender, RoutedEventArgs e)
        {
            combinedGeo1.Geometry1 = new EllipseGeometry() { RadiusX = 44, RadiusY = 144 };
        }
    }
}
