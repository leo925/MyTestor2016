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
    /// Interaction logic for WindowToolTip.xaml
    /// </summary>
    public partial class WindowToolTip : Window
    {
        
        public WindowToolTip()
        {
            InitializeComponent();
            TextBox tb;
            UserControl uc;
             
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(this.txt.ActualWidth);
            
        }
    }

    public class MultiToolTipCvt : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
