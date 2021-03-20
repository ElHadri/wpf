using System.Windows;

namespace CH07.BlogReader.Views
{
    /// <summary>
    /// Interaction logic for NewPostWindow.xaml
    /// </summary>
    public partial class NewPostWindow : Window
    {
        public NewPostWindow()
        {
            InitializeComponent();
        }

        private void OnOk(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
