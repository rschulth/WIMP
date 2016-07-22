using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginWPF.ViewModel.Common
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public DelegateCommand(Action<T> execute)
            : this(execute, (p) => true) {
            _execute = execute;
        }

        public DelegateCommand(Action<T> execute, Func<T, bool> canExecute) {
            _execute = execute;
            _canExecute = canExecute;
        }

        //ICommand
        public void Execute(object parameter) {
            T param = default(T);
            if (parameter is T)
                param = (T)parameter;
            _execute(param);
        }
        //ICommand
        public bool CanExecute(object parameter) {
            T param = default(T);
            if (parameter is T)
                param = (T)parameter;
            return _canExecute(param);
        }

        //register CanExecuteChanged with CommandManager
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
