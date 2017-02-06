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
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WindowRaceClock_Timer.xaml
    /// </summary>
    public partial class WindowRaceClock_Timer : Window
    {
        DispatcherTimer timer = null;
        TimeSpan span = new TimeSpan();
        DateTime startTime;
        public WindowRaceClock_Timer()
        {
            InitializeComponent();
            startTime = DateTime.Now;
            timer = new DispatcherTimer(new TimeSpan(0, 0, 0, 0, 1), DispatcherPriority.Normal, callback, this.Dispatcher);
        }

        private void callback(object sender, EventArgs e)
        {
            span = DateTime.Now - startTime;
            txt.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt1.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt2.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt3.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt4.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt5.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt6.Text = span.ToString();

            span = DateTime.Now - startTime;
            txt7.Text = span.ToString();
        }
    }
}
