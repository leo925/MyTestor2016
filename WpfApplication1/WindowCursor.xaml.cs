using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WindowCursor.xaml
    /// </summary>
    public partial class WindowCursor : Window
    {
        public WindowCursor()
        {
            InitializeComponent();
            string fromat=@"HH\:mm\:ss\.ff";
            string str = DateTime.Now.ToString(fromat);
            string ddd = str;

            DateTime dtOld = DateTime.Now.AddHours(-15);

            string NowString = (DateTime.Now - dtOld).ToString(@"hh\:mm\:ss\.ff");
            ddd = NowString;

        }

        private void ComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            ComboBox a;

        }

        private void ComboBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }

    public class ImageGifView : MediaElement
    {
        public ImageGifView()
        {
            this.Loaded += ImageGifView_Loaded;
        }

        private string imgSource;

        public string ImgSource
        {
            get
            {
                return imgSource;
            }
            set
            {
                imgSource = value;
            }
        }

        private void ImageGifView_Loaded(object sender, RoutedEventArgs e)
        {
            string str = @"E:\git\MyTestor2016\WpfApplication1\pic\battery_unknown5.gif";
            
           
            this.Width = 24;
            this.Height = 24;
            this.LoadedBehavior = MediaState.Play;
            this.Stretch = Stretch.Fill;

            //循环播放
            if (true)
            {
                this.MediaEnded += ImageGifView_MediaEnded;
            }

        }

        /// <summary>
        /// 结束后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageGifView_MediaEnded(object sender, RoutedEventArgs e)
        {

            MediaElement media = (MediaElement)sender;
            media.Position = TimeSpan.FromMilliseconds(1);
            //media.Play();

        }
    }
}
