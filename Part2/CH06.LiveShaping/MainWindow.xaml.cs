using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace CH06.LiveShaping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer = new DispatcherTimer();
        readonly ObservableCollection<StockItem> _items = new ObservableCollection<StockItem>();

        public MainWindow()
        {
            InitializeComponent();

            var rnd = new Random();
            string[] names = { "ABCD", "QTYD", "DHJD", "OIUI", "TRET", "AGSD", "YTJD", "MHHJ", "FRGD", "HDHE", "JAGH", "PERI" };
            Array.ForEach(names, s => _items.Add(new StockItem { Name = s, Value = rnd.Next(20, 50) }));

            DataContext = _items;

            var view = CollectionViewSource.GetDefaultView(_items);
            view.SortDescriptions.Add(new SortDescription("Value", ListSortDirection.Ascending));

            var liveview = (ICollectionViewLiveShaping)CollectionViewSource.GetDefaultView(_items);
            liveview.IsLiveSorting = true;

            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += delegate
            {
                foreach (var item in _items)
                    item.Value += rnd.Next(9) - 4;
            };
            _timer.Start();
        }
    }
}
