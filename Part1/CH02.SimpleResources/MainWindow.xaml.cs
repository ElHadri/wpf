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

namespace CH02.SimpleResources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rectangletoto.Fill = (Brush)rectangletoto.FindResource("brush1"); // same effect as:  Fill="{StaticResource brush1}"
            // or accessing a resource directly using an indexer.
            rectangletoto.Fill = (Brush)this.Resources["brush1"]; // same effect as:  Fill="{StaticResource brush1}"

            // Adding resources dynamically
            this.Resources.Add("brush2", new SolidColorBrush(Color.FromRgb(200, 10, 150)));
            rectanglefofo.Fill = (Brush)this.Resources["brush2"];
        }

        private void OnModifyResource(object sender, RoutedEventArgs e)
        {
            // Modifying resources dynamically (we keep the same instance ==> modification is seen by all elements referencing it)
            var brush = (LinearGradientBrush)this.Resources["brush1"];
            brush.GradientStops.Add(new GradientStop(Colors.Blue, .5));
        }

        private void OnChangeBrush(object sender, RoutedEventArgs e)
        {
            // Removing the resource
            this.Resources.Remove("brush1");
            // we create a new resource (new key + new instance)
            this.Resources.Add("brush1", new SolidColorBrush(Color.FromRgb(70, 19, 111)));
            // to see the result (because SaticResource)
            rectangletoto.Fill = (Brush)this.Resources["brush1"];

            // Removing the resource
            this.Resources.Remove("brush2");
            // to see the result (because SaticResource)
            rectanglefofo.Fill = (Brush)this.Resources["brush2"];
        }
    }
}
