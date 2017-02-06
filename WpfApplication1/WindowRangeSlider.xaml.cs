using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for WindowRangeSlider.xaml
    /// </summary>
    public partial class WindowRangeSlider : Window, INotifyPropertyChanged
    {
        public WindowRangeSlider()
        {
            InitializeComponent();
            this.DataContext = this;
            M();
             
        }

        void M()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
            var frs = st.GetFrames();
            foreach (var f in frs)
            {


            }
        }
            


        private RangeSliderViewModel vm;

        public RangeSliderViewModel VM
        {
            get
            {
                return vm;
            }
            set
            {
                vm = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("VM"));
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VM = new RangeSliderViewModel()
            {
                Maximum=100,
                Minimum=20, 
                Value=22,
                BarHeight=12
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.Value++;
        }
    }
}
