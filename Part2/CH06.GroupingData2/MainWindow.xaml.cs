using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace CH06.GroupingData2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var processes = Process.GetProcesses().Where(CanAccess);
            DataContext = processes;

            var view = CollectionViewSource.GetDefaultView(processes);
            view.GroupDescriptions.Add(new PropertyGroupDescription("Threads.Count", new ThreadsToGroupConverter()));
        }

        public static bool CanAccess(Process process)
        {
            try
            {
                var h = process.Handle;
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
