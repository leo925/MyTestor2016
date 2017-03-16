using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for WindowThread.xaml
    /// </summary>
    public partial class WindowThread : Window
    {
        public WindowThread()
        {
            InitializeComponent();
            int m1, m2;
            ThreadPool.GetMinThreads(out m1, out m2);
            ThreadPool.SetMinThreads(300, 400);
            ThreadPool.GetMinThreads(out m1, out m2);  
            
               
        }
        Timer t;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             t = new Timer(back, null, 0, 500);
        }

        private void back(object state)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.t.Change(5, Timeout.Infinite);
        }
    }



    public class SettingsDisplayViewModel
    {
        int Type;
        List<SettingDisplayItemViewModel> list;
        void m()
        {

        }
    }

    public class SettingDisplayItemViewModel
    {
        public int Type;
        string distanceName;
        List<WaveSettingItemViewModel> listwave;

        //here, have another view mdoel to represents the displaying data

        distanceSettingItemViewModel distanceViewModel;

        

    }

    class WaveSettingsViewModel
    {
        List<WaveSettingItemViewModel> list;
    }

    class WaveSettingItemViewModel
    {
    }

    class distanceSettingItemViewModel
    {
    }
}
