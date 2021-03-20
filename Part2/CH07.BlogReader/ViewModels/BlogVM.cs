using CH07.BlogReader.Commands;
using CH07.BlogReader.Models;
using CH07.BlogReader.Views;
using CH07.CookbookMVVM;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;

namespace CH07.BlogReader.ViewModels
{

    // normalement il faut un "Client" qui va créer "Command" (with "Receiver", ici y a pas) et puis l'affecter à "Invoker = BlogVM"
    // Ici "Command" est créée sur place avec tous les détails. Donc pas besoin d'implémenter "SetCommand()"
    public class BlogVM : ViewModelBase<Blog, MainVM>
    {
        public BlogVM(Blog blog, MainVM parent) : base(blog, parent)
        {
            /* allow the ViewModel to be notified when something interesting has changed in the model, so it can appropriately update itself. */
            var notify = (INotifyCollectionChanged)blog.Posts;
            if (notify != null)
            {
                notify.CollectionChanged += delegate
                {
                    OnPropertyChanged("Posts");
                };
            }
        }

        public IDialogService NewPostDialogService { get; set; }

        private ICommand _newPostCommand;
        public ICommand NewPostCommand   /*******************************/
        {
            get
            {
                if (NewPostDialogService == null)
                {
                    NewPostDialogService = new StandardDialogService<NewPostWindow>();
                }

                return _newPostCommand ?? (_newPostCommand = new RelayCommand<BlogPost>(
                    post => /* passed when command is triggered */
                    {
                        if (post == null) /* If no post is provided, this means the command is invoked from the regular UI */
                            post = new BlogPost();
                        else
                        {
                            /* the provided blog post is used as is */
                        }

                        NewPostDialogService.ViewModel = new BlogPostVM { Model = post };

                        if (NewPostDialogService.ShowDialog() == true)
                        {
                            post.When = DateTime.Now; // set the Model "BlogPost"

                            /* deleted------------*/
                            // this.Model.Posts.Add(post);    // update the Model "Blog"
                            // OnPropertyChanged("Posts");
                            /* deleted------------*/

                            /* replaced by ---------*/
                            var cmd = new ReversibleCommand(
                                new NewBlogPostCommand(this.Model), 
                                this.Parent.UndoManager);

                            cmd.Execute(post);
                            /* replaced by ---------*/
                        }
                    }, 
                    null));
            }
        }

        public BloggerVM Blogger   /*******************************/
        {
            get
            {
                return new BloggerVM() { Model = this.Model.Blogger };
            }
        }

        public IEnumerable<BlogPostVM> Posts    /*******************************/
        {
            get
            {
                return this.Model.Posts.Select(post => new BlogPostVM { Model = post });
            }
        }

    }
}
