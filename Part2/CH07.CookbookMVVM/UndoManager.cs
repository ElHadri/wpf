using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.CookbookMVVM
{
    public class UndoManager
    {
        readonly List<IUndoCommand> _undoList;
        readonly List<IUndoCommand> _redoList;
        public int UndoLimit { get; private set; }
        public virtual bool CanUndo { get { return _undoList.Count > 0; } }
        public virtual bool CanRedo { get { return _redoList.Count > 0; } }

        public UndoManager(int limit = 0)
        {
            if (limit < 0)
                throw new ArgumentException("undo limit must be a positive integer", "limit");

            UndoLimit = limit; // can contain 0,1,....,n
            _undoList = new List<IUndoCommand>(limit > 0 ? limit : 16); // the list may contain 1,2,.......,n OR 16
            _redoList = new List<IUndoCommand>(limit > 0 ? limit : 16); // the list may contain 1,2,.......,n OR 16
        }

        // why not verify before calling this method ?
        public void AddCommand(IUndoCommand cmd)
        {
            _undoList.Add(cmd); // stackoverflow ?????
            _redoList.Clear();

            if(UndoLimit>0 && _undoList.Count > UndoLimit)
            {
                _undoList.RemoveAt(0);
            }
        }

        public virtual void Undo()
        {
            if (!CanUndo)
                throw new InvalidOperationException("can't undo");

            int index = _undoList.Count - 1;

            _undoList[index].Undo();
            _redoList.Add(_undoList[index]);
            _undoList.RemoveAt(index);
        }

        public virtual void Redo()
        {
            if (!CanRedo)
                throw new InvalidOperationException("can't redo");

            int index = _redoList.Count - 1;

            _redoList[index].Execute(null);
            _undoList.Add(_redoList[index]);
            _redoList.RemoveAt(index);
        }
    }
}
