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

namespace CH06.WeatherForecast
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Days;

        public MainWindow()
        {
            InitializeComponent();
            _days.ItemsSource = Enumerable.Range(1, 10);
            Days = (int)_days.SelectedItem;
        }

        private void OnGetForecast(object sender, RoutedEventArgs e)
        {
            Days = (int)_days.SelectedItem;
            var data = new List<Forecast>();
            var rnd = new Random();
            for (int i = 0; i < Days; i++)
            {
                double temp = rnd.NextDouble() * 40 - 10;
                var forecast = new Forecast
                {
                    GeneralForecast = (GeneralForecast)rnd.Next(Enum.GetValues(typeof(GeneralForecast)).Length),
                    TemperatureLow = temp,
                    TemperatureHigh = temp + rnd.NextDouble() * 15,
                    Percipitation = rnd.Next(10) > 5 ? rnd.NextDouble() * 10 : 0
                };
                data.Add(forecast);
            }
            DataContext = data;
        }
    }
}
