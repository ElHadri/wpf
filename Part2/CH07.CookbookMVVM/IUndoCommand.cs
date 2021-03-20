using System.Windows.Input;

namespace CH07.CookbookMVVM
{
    public interface IUndoCommand : ICommand
    {
        void Undo();
    }
}
