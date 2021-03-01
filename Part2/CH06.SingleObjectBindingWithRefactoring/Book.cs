using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.SingleObjectBindingWithRefactoring
{
    class Book : ObservableObject
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private int _pages;
        public int Pages
        {
            get { return _pages; }
            set { SetProperty(ref _pages, value); }
        }
    }
}
