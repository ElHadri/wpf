using System.Collections.ObjectModel;
using System.Windows;

namespace CH06.DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person { Age = 10, Name = "Bart" };
            _list.ItemsSource = new ObservableCollection<Person> {
                new Person { Name = "Bart", Age = 10 },
                new Person { Name = "Homer", Age = 45 },
                new Person { Name = "Marge", Age = 35 }
            };
            _bookList.ItemsSource = new ObservableCollection<Book> {
                new Book { Title = "C#", Pages = 100 },
                new Book { Title = "Java", Pages = 200 },
                new Book { Title = "Marge", Pages = 300 }
            };
        }

        private void OnAddItem(object sender, RoutedEventArgs e)
        {
            _list2.Items.Add(new Person { Name = "AAA", Age = 555 });
        }
    }
}
