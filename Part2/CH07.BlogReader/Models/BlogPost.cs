using CH07.CookbookMVVM;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CH07.BlogReader.Models
{
    public class BlogPost : ObservableObject
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
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

        private ObservableCollection<BlogComment> _comments = new ObservableCollection<BlogComment>();
        public IList<BlogComment> Comments
        {
            get { return _comments; }  // read-only
        }
    }
}


