using System.Windows;

namespace CH06.ValidatingData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Person { Name = "Adil", Age = 10 };
        }
    }
}
