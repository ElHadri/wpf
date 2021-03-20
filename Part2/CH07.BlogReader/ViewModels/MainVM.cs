using CH07.BlogReader.Models;
using CH07.CookbookMVVM;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace CH07.BlogReader.ViewModels {
    public class MainVM: ViewModelBase<IEnumerable<Blog>> {

        public UndoManager UndoManager { get; private set; }

        // ctor
        public MainVM(IEnumerable<Blog> blogs) {
            Model = new ObservableCollection<Blog>(blogs);
            UndoManager = new UndoManager();
        }

        private ICommand _undoCommand;
        public ICommand UndoCommand /*******************************/
        {
            get {
                return _undoCommand ?? (_undoCommand = new RelayCommand(() => UndoManager.Undo() ,() => UndoManager.CanUndo));
            }
        }

        private ICommand _redoCommand;
        public ICommand RedoCommand /*******************************/
        {
            get {
                return _redoCommand ?? (_redoCommand = new RelayCommand(() => UndoManager.Redo() ,() => UndoManager.CanRedo));
            }
        }


        public IEnumerable<BlogVM> Blogs     /*******************************/
        {
            get {
                return Model.Select(blog => new BlogVM(blog ,this));
            }
        }

        private BlogVM _selectedBlog;
        public BlogVM SelectedBlog    /*******************************/
        {
            get { return _selectedBlog; }
            set {
                if(SetProperty(ref _selectedBlog ,value))
                    OnPropertyChanged("IsSelectedBlog");
            }
        }

        public Visibility IsSelectedBlog    /*******************************/
        {
            get {
                return SelectedBlog != null ? Visibility.Visible : Visibility.Collapsed;
            }
        }

    }
}
