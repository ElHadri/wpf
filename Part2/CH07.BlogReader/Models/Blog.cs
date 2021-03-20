using CH07.CookbookMVVM;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CH07.BlogReader.Models
{
    public class Blog : ObservableObject
    {
        private Blogger _blogger;
        public Blogger Blogger
        {
            get { return _blogger; }
            set { SetProperty(ref _blogger, value); }
        }

        private string _blogTitle;
        public string BlogTitle
        {
            get { return _blogTitle; }
            set { SetProperty(ref _blogTitle, value); }
        }

        private ObservableCollection<BlogPost> _posts = new ObservableCollection<BlogPost>();
        public IList<BlogPost> Posts
        {
            get { return _posts; } // read-only
        }
    }
}
