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

namespace MyFirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Content = "Hello";

           
        }

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y { get; set; }


        public int MySample
        {
            get { return (int)GetValue(MySampleProperty); }
            set { SetValue(MySampleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MySample.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MySampleProperty =
            DependencyProperty.Register("MySample", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


    }
}
