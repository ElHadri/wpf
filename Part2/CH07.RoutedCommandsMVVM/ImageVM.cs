using Commands;

using System.ComponentModel;
using System.Windows.Input;

namespace CH07.RoutedCommandsMVVM
{
    /* Client&Invoker - View Model*/
    public class ImageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ICommand _openImageFileCommand;
        private ICommand _zoomCommand;

        public ImageVM()
        {
            _openImageFileCommand = new OpenImageFileCommand(this);
            _zoomCommand = new ZoomCommand(this);
        }

        public ICommand OpenImageFileCommand
        {
            get { return _openImageFileCommand; }
        }
        public ICommand ZoomCommand
        {
            get { return _zoomCommand; }
        }

        double _zoom = 1.0;
        public double Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Zoom"));
            }
        }

        string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ImagePath"));
            }
        }
    }
}