using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Threading;

namespace CH05.UnhandledExceptions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DispatcherUnhandledException += OnUnhandledException;
        }

        private void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            Trace.WriteLine(string.Format($"{DateTime.Now}: Error: {e.Exception}"));
            MessageBox.Show("Error encountered! Please contact support." + Environment.NewLine + e.Exception.Message);
            Shutdown(1);
            e.Handled = true;
        }
    }
}
