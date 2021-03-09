using System.ComponentModel;

namespace CH07.RoutedCommands
{
    class ImageData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

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

        public string ImagePath { get; private set; }

        public ImageData(string path)
        {
            ImagePath = path;
        }
    }
}
