using CH07.BlogReader.Models;
using CH07.BlogReader.Views;
using CH07.CookbookMVVM;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace CH07.BlogReader.ViewModels
{

    // normalement il faut un "Client" qui va créer "Command" (with "Receiver", ici y a pas) et puis l'affecter à "Invoker = BlogVM"
    // Ici "Command" est créée sur place avec tous les détails. Donc pas besoin d'implémenter "SetCommand()"
    public class BlogVM : ViewModelBase<Blog>
    {
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
                            this.Model.Posts.Add(post);    // update the Model "Blog"
                            OnPropertyChanged("Posts");
                        }


                        /* Old version before having "IDialogService" */
                        //var post = new BlogPost(); // "BlogPost" is temp
                        //var dlg = new NewPostWindow() // "NewPostWindow" is temp
                        //{
                        //    DataContext = new BlogPostVM { Model = post }  // "BlogPostVM" is temp
                        //};

                        //if (dlg.ShowDialog() == true)
                        //{
                        //    post.When = DateTime.Now; // set the Model "BlogPost"
                        //    this.Model.Posts.Add(post);    // update the Model "Blog"
                        //    OnPropertyChanged("Posts");
                        //}
                    }, null));
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
