using CH07.RoutedCommandsMVVM;

using Microsoft.Win32;

using System;
using System.Windows.Input;

namespace Commands
{
    class OpenImageFileCommand : ICommand
    {
        private ImageDataVM _data;
        public OpenImageFileCommand(ImageDataVM data)
        {
            _data = data;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var dlg = new OpenFileDialog { Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif" };

            if (dlg.ShowDialog() == true)
            {
                _data.ImagePath = dlg.FileName;
            }
        }
    }
}
