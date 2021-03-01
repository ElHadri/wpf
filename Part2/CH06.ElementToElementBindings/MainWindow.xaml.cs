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

namespace CH06.ElementToElementBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnUpdateExplicitly(object sender, RoutedEventArgs e)
        {
            var expr = BindingOperations.GetBindingExpression(_text, TextBox.TextProperty);
            expr.UpdateSource();
        }

        //private void onValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    _textBlock.FontSize = _slider.Value;
        //}

    }
}
