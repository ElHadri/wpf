using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CH07.CookbookMVVM
{
    // helper class
    // implement a command generically by supplying delegates as implementations for Execute and CanExecute.
    // This works up to a point.When dealing with undo/redo, a state must be maintained, so using RelayCommand is not enough in most cases.
    public class RelayCommand<T> : ICommand
    {

        readonly Action<T> _execute;
        readonly Func<T, bool> _canExecute;

        public RelayCommand(Action<T> execute, Func<T, bool> canExecute=null)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _execute = execute;

            if (canExecute == null)
            {
                _canExecute = (T) => true;
            }
            else
            {
                _canExecute = canExecute;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { if (_canExecute != null) CommandManager.RequerySuggested += value; }
            remove { if (_canExecute != null) CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            T value = default(T);
            if (parameter != null && typeof(T).IsEnum)
                value = (T)Enum.Parse(typeof(T), (string)parameter);
            else
                value = (T)parameter;

            return _canExecute.Invoke(value);
        }

        public void Execute(object parameter)
        {
            T value = default(T);
            if (parameter != null && typeof(T).IsEnum)
                value = (T)Enum.Parse(typeof(T), (string)parameter);
            else
                value = (T)parameter;

            _execute.Invoke(value);
        }
    }
    //-------------------------------------------------------------------------------------------------------------------
    public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action execute, Func<bool> canExecute = null)
            : base(obj => execute(), (canExecute == null ? null : new Func<object, bool>(obj => canExecute())))
        {
        }
    }
}
