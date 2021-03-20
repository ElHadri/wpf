using CH07.BlogReader.Models;
using CH07.CookbookMVVM;

using System;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CH07.BlogReader.ViewModels
{
    public class BloggerVM : ViewModelBase<Blogger>
    {

        private ICommand _sendEmailCommand;
        public ICommand SendEmailCommand
        {
            get
            {
                return _sendEmailCommand ?? (_sendEmailCommand = new RelayCommand<string>(
                    email => Process.Start(new ProcessStartInfo("mailto: " + email) { UseShellExecute = true })));
                //email => Process.Start("mailto:" + email)  /* in the book */
            }
        }

        public ImageSource Picture
        {
            get
            {
                if (Model.Picture == null)
                    return new BitmapImage(new Uri("/Images/blogger.png", UriKind.Relative));

                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = Model.Picture;
                bmp.EndInit();

                return bmp;
            }
        }
    }
}
