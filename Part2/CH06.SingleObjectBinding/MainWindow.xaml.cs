using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CH06.SingleObjectBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Person _person = new Person { Name = "Bart", Age = 10 };  // replace private to avoid message squiggles

        public MainWindow()
        {
            InitializeComponent();
            //_person.PropertyChanged += UpdateAge;
            DataContext = _person;
        }

        //private void UpdateAge(object broadcaster, PropertyChangedEventArgs e)
        //{
        //    _age.Text = _person.Age.ToString();
        //}

        private void OnChange(object sender, RoutedEventArgs e)
        {
            _person.Age++;
        }
    }
}
