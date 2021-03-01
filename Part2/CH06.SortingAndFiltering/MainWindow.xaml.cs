using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;

namespace CH06.SortingAndFiltering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CollectionViewSource _cvs1;
        private CollectionViewSource _cvs2;

        private Process[] Processes;

        public MainWindow()
        {
            InitializeComponent();
            Processes = Process.GetProcesses(); // single actual data collection

            //_list1.DataContext = Processes;  // our problem
            _cvs1 = new CollectionViewSource();
            _cvs1.Source = Processes;
            _list1.DataContext = _cvs1;

            //_list2.DataContext = Processes;  // our problem
            _cvs2 = new CollectionViewSource();
            _cvs2.Source = Processes;
            _list2.DataContext = _cvs2;
        }

        private void OnSort(object sender, RoutedEventArgs e)
        {
            var view1 = _cvs1.View;
            //var view1 = CollectionViewSource.GetDefaultView(_list1.DataContext); // our problem (view1 & view2 are the same)
            view1.SortDescriptions.Clear();
            if (_sortField.SelectedValue != null)
                view1.SortDescriptions.Add(new SortDescription(
                    (string)_sortField.SelectedValue,
                    _ascending.IsChecked == true ?
                        ListSortDirection.Ascending :
                        ListSortDirection.Descending));
        }

        private void OnFilter(object sender, RoutedEventArgs e)
        {
            var view2 = _cvs2.View;
            //var view2 = CollectionViewSource.GetDefaultView(_list2.DataContext); // our problem (view1 & view2 are the same)
            if (string.IsNullOrWhiteSpace(_filterText.Text))
                view2.Filter = null;
            else
                view2.Filter = (obj => (((Process)obj).ProcessName.IndexOf(_filterText.Text, StringComparison.InvariantCultureIgnoreCase)) > (-1));
        }
    }
}