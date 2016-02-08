using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace MySimpleEditor
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

        private void OnClose(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == true)
            {
                string fileName = dlg.FileName;
                text1.Text = File.ReadAllText(fileName);
            }
        }

        private void OnSave(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
