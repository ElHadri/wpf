using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CH07.CookbookMVVM
{
    public sealed class StandardDialogService<TWindow> : IDialogService where TWindow : Window, new()
    {
        public object ViewModel { get; set; }

        public bool? ShowDialog()
        {
            var dlg = new TWindow() // "TWindow" is temp
            {
                DataContext = ViewModel  // "BlogPostVM" is temp
            };

            return dlg.ShowDialog();
        }
    }
}