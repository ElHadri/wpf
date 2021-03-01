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

namespace CH02.DynamicVsStatic
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

        private void OnModifyTheSameResourceInstance(object sender, RoutedEventArgs e)
        {
            var brush = (LinearGradientBrush)this.Resources["brush1"];
            brush.GradientStops.Add(new GradientStop(Colors.Blue, .5));
        }

        private void OnReplaceResourceInstanceButKeepKeyName(object sender, RoutedEventArgs e)
        {
            var newBrushInstance = new LinearGradientBrush();
            newBrushInstance.GradientStops.Add(new GradientStop(Colors.Green, 0));
            newBrushInstance.GradientStops.Add(new GradientStop(Colors.White, 1));
            this.Resources["brush2"] = newBrushInstance;
        }

    }
}
