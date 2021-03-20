using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.CookbookMVVM
{
    public interface IDialogService
    {
        bool? ShowDialog();
        object ViewModel { get; set; }
    }
}
