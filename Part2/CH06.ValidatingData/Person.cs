using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.ValidatingData
{
    class Person : INotifyPropertyChanged /*, IDataErrorInfo*/
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // method 1
        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        // method 2 (a class like "MinCharsRule" no needed)
        int _age;
        [Range(1, 120, ErrorMessage = "Age must be a positive integer")]
        public int Age
        {
            get { return _age; }
            set
            {
                ValidateProperty(value, "Age");
                _age = value;
                OnPropertyChanged("Age");
            }
        }


        // helper
        protected void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }

        protected virtual void OnPropertyChanged(string propName)
        {
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(propName));
        }

        //---IDataErrorInfo--------------------------------------------------------------------

        // never called by WPF
        //public string Error
        //{
        //    get { return null; }
        //}

        //public string this[string columnName]
        //{
        //    get
        //    {
        //        switch (columnName)
        //        {
        //            case "Name":
        //                if (string.IsNullOrWhiteSpace(Name))
        //                    return "Name cannot be empty";
        //                break;
        //            case "Age":
        //                if (Age < 1)
        //                    return "Age must be a positive integer";
        //                break;
        //        }
        //        return null;
        //    }
        //}
    }
}
