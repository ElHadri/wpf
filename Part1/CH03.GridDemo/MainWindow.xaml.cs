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

namespace CH03.GridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new List<Person> {
                new Person { Name = "Bart", Age = 10 },
                new Person { Name = "Marge", Age = 35 },
                new Person { Name = "Homer", Age = 40 },
                new Person { Name = "Lisa", Age = 12 },
                new Person { Name = "Maggieeeeeeeeeeeeeeeeee", Age = 2 },
                new Person { Name = "Bart", Age = 10 },
                new Person { Name = "Marge", Age = 35 },
                new Person { Name = "Homer", Age = 40 },
                new Person { Name = "Lisa", Age = 12 },
                new Person { Name = "Maggieeeeeeeeeeeeeeeeee", Age = 2 },
            };

        }

        private void OnAddRow(object sender, RoutedEventArgs e)
        {
            _grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
        }
    }
}
