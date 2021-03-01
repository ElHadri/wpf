using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CH05.NewWindows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Window mainWindow = null;
            // check some state or setting as appropriate
            if (ConfigurationManager.AppSettings["AdvancedMode"] == "1")
                mainWindow = new OtherWindow();
            else
                mainWindow = new MainWindow();

            mainWindow.Show();
        }
    }


}
