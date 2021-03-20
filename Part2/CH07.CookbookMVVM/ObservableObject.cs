using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace CH07.CookbookMVVM
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        // "bool" is used in "MainVM"
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field,value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }


        // je suis obligé de réfactorer, sinon je ne pourrai pas utiliser "PropertyChanged.Invoke" en dehors de cette classe "ObservableObject"
        protected virtual void OnPropertyChanged(string propertyName)
        {
            //Debug.Assert(GetType().GetProperty(propertyName) != null);
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
