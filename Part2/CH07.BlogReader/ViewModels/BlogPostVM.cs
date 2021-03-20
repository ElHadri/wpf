using CH07.BlogReader.Models;
using CH07.BlogReader.Views;
using CH07.CookbookMVVM;

using System;
using System.Windows.Input;

namespace CH07.BlogReader.ViewModels
{
    public class BlogPostVM : ViewModelBase<BlogPost>
    {
        private ICommand _newCommentCommand;
        public ICommand NewCommentCommand
        {
            get
            {
                return _newCommentCommand ?? (_newCommentCommand = new RelayCommand(() =>
                {
                    var comment = new BlogComment();
                    var dlg = new NewCommentWindow
                    {
                        DataContext = new BlogCommentVM { Model = comment }
                    };
                    if (dlg.ShowDialog() == true)
                    {
                        comment.When = DateTime.Now; // set the Model "BlogComment"
                        Model.Comments.Add(comment); // update the Model "BlogPost"
                    }
                }));
            }
        }


        public string Title
        {
            get { return Model.Title; }
            set
            {
                Model.Title = value;
                OnPropertyChanged("IsPostOK");
            }
        }


        public string Text
        {
            get { return Model.Text; }
            set
            {
                Model.Text = value;
                OnPropertyChanged("IsPostOK");
            }
        }

        public bool IsPostOk
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Model.Title) &&
                    !string.IsNullOrWhiteSpace(Model.Text);
            }
        }
    }
}
