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

namespace ValidationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SampleData _sampleData = new SampleData();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _sampleData;
        }

        private void OnShowData(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_sampleData.Val1.ToString(), _sampleData.Val2.ToString());
        }
    }
}
