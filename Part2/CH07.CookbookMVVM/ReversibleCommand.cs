using System;
using System.Windows.Input;

namespace CH07.CookbookMVVM
{
    public sealed class ReversibleCommand : ICommand
    {
        readonly IUndoCommand _command;
        readonly UndoManager _mgr;

        // for each command I must pass a new instance of UndoManager ????  I think I must pass the same instance
        public ReversibleCommand(IUndoCommand cmd, UndoManager mgr)
        {
            _command = cmd;
            _mgr = mgr;
        }


        public event EventHandler CanExecuteChanged
        {
            add { _command.CanExecuteChanged += value; }
            remove { _command.CanExecuteChanged -= value; }
        }


        public bool CanExecute(object parameter)
        {
            return _command.CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _command.Execute(parameter);
            _mgr.AddCommand(_command);
        }
    }
}
