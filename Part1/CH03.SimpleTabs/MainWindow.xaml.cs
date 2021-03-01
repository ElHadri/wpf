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

namespace CH03.SimpleTabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //_tabs.ItemsSource = new List<DataItem> { 
            //    new DataItem { Header = "Header 1", Text = "Data 1 " }, 
            //    new DataItem { Header = "Header 2", Text = "Data 2 " }, 
            //    new DataItem { Header = "Header 3", Text = "Data 3 " },
            //};
        }

        private readonly Random _random = new Random();

        private void OnAddTab(object sender, RoutedEventArgs e)
        {
            int number = _random.Next(1, 100);
            _tabs.Items.Add(new DataItem { Header = $"Header {number}", Text = $"Data {number} " });
        }
    }
}
