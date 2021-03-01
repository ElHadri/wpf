using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CH06.SingleObjectBinding
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value == _age) return;
                _age = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }
    }
}
