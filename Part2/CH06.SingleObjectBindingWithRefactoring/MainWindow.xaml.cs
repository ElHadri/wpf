using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CH06.SingleObjectBindingWithRefactoring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Person _person = new Person { Name = "Bart", Age = 10 }; // replace private to avoid message squiggles
        readonly Book _book = new Book { Title = "C#", Pages = 100 };

        public MainWindow()
        {
            InitializeComponent();
            _personName.DataContext = _person;
            _personAge.DataContext = _person;
            _bookTitle.DataContext = _book;
            _bookPages.DataContext = _book;
        }

        private void OnChange(object sender, RoutedEventArgs e)
        {
            _person.Age++;
            _book.Pages++;
        }
    }
}
