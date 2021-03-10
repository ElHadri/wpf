using CH07.RoutedCommandsMVVM;

using System;
using System.Windows.Input;

namespace Commands
{
    class ZoomCommand : ICommand
    {
        private ImageVM _data;
        public ZoomCommand(ImageVM data)
        {
            _data = data;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)  /* parameter is zoom type */
        {
            return _data.ImagePath != null;
        }

        public void Execute(object parameter)  /* parameter is zoom type */
        {
            var zoomType = (EnumZoomType)Enum.Parse(
                typeof(EnumZoomType),
                (string)parameter,
                true);

            switch (zoomType)
            {
                case EnumZoomType.ZoomIn:
                    _data.Zoom *= 1.2;
                    break;
                case EnumZoomType.ZoomOut:
                    _data.Zoom /= 1.2;
                    break;
                case EnumZoomType.ZoomNormal:
                    _data.Zoom = 1.0;
                    break;
            }
        }
    }
}
