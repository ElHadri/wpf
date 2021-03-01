using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.SingleObjectBindingWithRefactoring
{
    class Person : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }
    }
}


//set
//{
//    if (value == _age) return;
//    _age = value;
//    RaisePropertyChangedEvent("Age");
//}
