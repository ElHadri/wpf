using CH07.CookbookMVVM;

using System.IO;

namespace CH07.BlogReader.Models
{
    public class Blogger : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private Stream _picture;
        public Stream Picture
        {
            get { return _picture; }
            set { SetProperty(ref _picture, value); }
        }
    }
}
