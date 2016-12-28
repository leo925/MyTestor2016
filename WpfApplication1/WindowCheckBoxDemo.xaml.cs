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
    /// Interaction logic for WindowCheckBoxDemo.xaml
    /// </summary>
    public partial class WindowCheckBoxDemo : Window
    {
        public WindowCheckBoxDemo()
        {
            InitializeComponent();
            var date = DateTime.Now;
            var month = date.ToString("MMM");
            Console.WriteLine(month);

            Grid grd = new Grid();
            grd.ColumnDefinitions.Add(new ColumnDefinition()
            {
                 Width=new GridLength (1.0, GridUnitType.Star) 
            });
        }
    }
}
