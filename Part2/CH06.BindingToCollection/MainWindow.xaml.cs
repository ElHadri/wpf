using System.Collections.ObjectModel;
using System.Windows;

namespace CH06.BindingToCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ObservableCollection<Person> _people = new ObservableCollection<Person> {
            new Person { Name = "Bart", Age = 10 },
            new Person { Name = "Homer", Age = 45 },
            new Person { Name = "Marge", Age = 35 },
            new Person { Name = "Lisa", Age = 12 },
            new Person { Name = "Maggie", Age = 1 }
        };

        public MainWindow()
        {
            InitializeComponent();
            //_list.ItemsSource = _people; OR
            _list.DataContext = _people;
            _combo.DataContext = _people;
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            _people.Add(new Person { Name = "Moe", Age = 40 });
        }

    }
}
