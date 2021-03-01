using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CH05.SingleInstApp
{

    public partial class App : Application
    {
        [DllImport("user32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(string cls, string win);
        [DllImport("user32")]
        static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32")]
        static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32")]
        static extern bool OpenIcon(IntPtr hWnd);

        protected override void OnStartup(StartupEventArgs e)
        {
            bool isNew;
            var mutex = new Mutex(true, "MySingleInstMutex", out isNew);
            if (!isNew)
            {
                ActivateOtherWindow();
                Shutdown(); // kill the new instance
            }
        }

        private static void ActivateOtherWindow()
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
