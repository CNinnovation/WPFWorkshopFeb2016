using MVVMSampleLib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSample.LocalServices
{
    public class MyMessageService : IMessageContract
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
