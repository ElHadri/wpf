using Commands;

using System.Windows;

namespace CH07.RoutedCommandsMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = new MainWindow(); // View
            var imageVM = new ImageVM(); // here I consider "ImageVM" as a ViewModel
            mainWindow.DataContext = imageVM;

            // here I consider "ImageVM" as an Invoker
            imageVM.SetCommand(new OpenImageFileCommand(imageVM), new ZoomCommand(imageVM));

            mainWindow.Show();
        }
    }
}
