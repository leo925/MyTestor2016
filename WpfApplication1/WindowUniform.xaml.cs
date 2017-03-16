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
    /// Interaction logic for WindowUniform.xaml
    /// </summary>
    public partial class WindowUniform : Window
    {
        public WindowUniform()
        {
            InitializeComponent();
            long l =1111111111;
            string text = string.Format("{0:000,0}", l);
            var df = text;

            WrapPanel wp;
            
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(e.ClickCount);
        }
    }
}
