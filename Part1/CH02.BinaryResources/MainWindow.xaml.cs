using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CH02.BinaryResources
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

        //Stream GetResourceStream(string name)
        //{
        //    string asmName = Assembly.GetExecutingAssembly().GetName().Name;
        //    var rm = new ResourceManager(asmName + ".g",Assembly.GetExecutingAssembly());
        //    using (var set = rm.GetResourceSet(CultureInfo.CurrentCulture, true, true))
        //    {
        //        return (Stream)set.GetObject(name, true);
        //    }
        //}

        private void OnReadBooks(object sender, RoutedEventArgs e)
        {
            var info = Application.GetResourceStream(new Uri("books.xml", UriKind.Relative));
            var books = XElement.Load(info.Stream);

            //var info = GetResourceStream("books.xml");
            //var books = XElement.Load(info);


            var bookList = from book in books.Elements("Book")
                           orderby (string)book.Attribute("Author")
                           select new
                           {
                               Name = (string)book.Attribute("Name"),
                               Author = (string)book.Attribute("Author")
                           };
            foreach (var book in bookList)
                _text.Text += book.ToString() + Environment.NewLine;

        }
    }
}
