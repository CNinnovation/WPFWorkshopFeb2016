using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AnotherSuperCoolFramework
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action action)
            : this(action, null)
        {

        }

        public DelegateCommand(Action action, Func<bool> canExecute)
        {
            _execute = action;
            _canExecute = canExecute;
        }

        private Action _execute;
        private Func<bool> _canExecute;

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;


        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
