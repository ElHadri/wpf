using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CH05.SingleInstAppWCF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        const string _pipeAddress = "net.pipe://127.0.0.1/pipe/activation";
        ServiceHost _host;

        protected override void OnStartup(StartupEventArgs e)
        {
            bool isNew;
            var mutex = new Mutex(true, "MySingleInstanceMutex", out isNew);
            if (!isNew)
            {
                //ActivateOtherWindow();
                // use the service
                var svc = ChannelFactory<IActivateWindow>.CreateChannel(new NetNamedPipeBinding(), new EndpointAddress(_pipeAddress));
                svc.Activate(e.Args);
                Shutdown();
            }
            else
            {
                _host = new ServiceHost(typeof(ActivationService));
                _host.AddServiceEndpoint(typeof(IActivateWindow), new NetNamedPipeBinding(), _pipeAddress);
                _host.Open();
            }
        }


        [DllImport("user32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(string clsName, string winName);

        [DllImport("user32")]
        internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32")]
        internal static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32")]
        internal static extern bool OpenIcon(IntPtr hWnd);

        internal static void ActivateOtherWindow()
        {
            var other = FindWindow(null, "Single Instance");
            if (other != IntPtr.Zero)
            {
                SetForegroundWindow(other);
                if (IsIconic(other))
                    OpenIcon(other);
            }
        }
    }
}
