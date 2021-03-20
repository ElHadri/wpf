using CH07.CookbookMVVM;

using System;

namespace CH07.BlogReader.Models
{
    public class BlogComment : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private DateTime _when;
        public DateTime When
        {
            get { return _when; }
            set { SetProperty(ref _when, value); }
        }
    }
}
