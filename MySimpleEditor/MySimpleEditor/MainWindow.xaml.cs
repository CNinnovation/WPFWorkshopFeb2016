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

        private string _openedFileName;

        private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == true)
            {
                 _openedFileName = dlg.FileName;
                text1.Text = File.ReadAllText(_openedFileName);
            }
        }

        private void OnSaveAs(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == true)
            {
                string fileName = dlg.FileName;
                File.WriteAllText(fileName, text1.Text);
            }
        }

        private void OnSave(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void OnMyAction(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("My Action");
        }

        private void CanMyAction(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
