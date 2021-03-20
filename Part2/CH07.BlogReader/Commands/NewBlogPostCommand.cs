using CH07.BlogReader.Models;
using CH07.CookbookMVVM;

namespace CH07.BlogReader.Commands
{
    class NewBlogPostCommand : CommandBase
    {
        private Blog _blog;
        public NewBlogPostCommand(Blog blog)
        {
            _blog = blog;
        }

        private BlogPost _post;
        public override void Execute(object parameter)
        {
            if (_post == null) _post = (BlogPost)parameter;
            _blog.Posts.Add(_post);
        }

        public override void Undo()
        {
            _blog.Posts.Remove(_post);
        }
    }
}