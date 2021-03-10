using Commands;

using System.ComponentModel;
using System.Windows.Input;

namespace CH07.RoutedCommandsMVVM
{
    /* Invoker & View Model */
    public class ImageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ICommand _openImageFileCommand;
        public ICommand OpenImageFileCommand
        {
            get { return _openImageFileCommand; }
        }

        private ICommand _zoomCommand;
        public ICommand ZoomCommand
        {
            get { return _zoomCommand; }
        }

        private double _zoom = 1.0;
        public double Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Zoom"));
            }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ImagePath"));
            }
        }

        public void SetCommand(ICommand openImageFileCommand, ICommand zoomCommand)
        {
            _openImageFileCommand = openImageFileCommand;
            _zoomCommand = zoomCommand;
        }
    }
}