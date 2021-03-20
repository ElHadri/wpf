using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.CookbookMVVM
{
    public sealed class AutoDialogService : IDialogService
    {
        public object ViewModel { get; set; }
        public bool? DialogResult { get; set; }

        public AutoDialogService()
        {
            DialogResult = true;
        }

        public bool? ShowDialog()
        {
            return DialogResult;
        }
    }
}
