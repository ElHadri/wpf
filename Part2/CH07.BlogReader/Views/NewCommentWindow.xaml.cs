using System.Windows;

namespace CH07.BlogReader.Views
{
    /// <summary>
    /// Interaction logic for NewCommentWindow.xaml
    /// </summary>
    public partial class NewCommentWindow : Window
    {
        public NewCommentWindow()
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
