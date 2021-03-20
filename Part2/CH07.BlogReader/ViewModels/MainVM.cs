using CH07.BlogReader.Models;
using CH07.CookbookMVVM;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CH07.BlogReader.ViewModels
{
    class MainVM : ViewModelBase<IEnumerable<Blog>>
    {

        public MainVM(IEnumerable<Blog> blogs)
        {
            Model = new ObservableCollection<Blog>(blogs);
        }

        public IEnumerable<BlogVM> Blogs     /*******************************/
        {
            get
            {
                return Model.Select(blog => new BlogVM { Model = blog });
            }
        }

        private BlogVM _selectedBlog;
        public BlogVM SelectedBlog    /*******************************/
        {
            get { return _selectedBlog; }
            set
            {
                if (SetProperty(ref _selectedBlog, value))
                    OnPropertyChanged("IsSelectedBlog");
            }
        }

        public Visibility IsSelectedBlog    /*******************************/
        {
            get
            {
                return SelectedBlog != null ? Visibility.Visible : Visibility.Collapsed;
            }
        }

    }
}
