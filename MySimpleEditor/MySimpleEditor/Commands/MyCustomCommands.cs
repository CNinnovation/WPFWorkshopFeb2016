using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleEditor.Commands
{
    public static class MyCustomCommands
    {
        private static RoutedUICommand _myAction;

        public static RoutedUICommand MyAction
        {
            get
            {
                return _myAction ?? (_myAction = new RoutedUICommand("Action1", "Action1", typeof(MyCustomCommands)));
            }
        }
    }
}
