using Common;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for RangeSlider.xaml
    /// </summary>
    public partial class RangeSlider : UserControl
    {
        public RangeSlider()
        {
            InitializeComponent();
        }


       
        public double LowerValue
        {
            get
            {
                return (double)GetValue(LowerValueProperty);
            }
            set
            {
                SetValue(LowerValueProperty, value);
            }
        }

        public static readonly DependencyProperty LowerValueProperty =
            DependencyProperty.Register("LowerValue", typeof(double), typeof(RangeSlider), new UIPropertyMetadata(0d));

        public double UpperValue
        {
            get
            {
                return (double)GetValue(UpperValueProperty);
            }
            set
            {
                SetValue(UpperValueProperty, value);
            }
        }

        public static readonly DependencyProperty UpperValueProperty =
            DependencyProperty.Register("UpperValue", typeof(double), typeof(RangeSlider), new UIPropertyMetadata(0d));

        

    }


    public class RangeSliderViewModel : BaseViewModel
    {
        private double barHeight=10;

        public double BarHeight
        {
            get
            {
                return barHeight;
            }
            set
            {
                barHeight = value;
                base.OnPropertyChanged("BarHeight");
            }
        }

        private double maximum;

        public double Maximum
        {
            get
            {
                return maximum;
            }
            set
            {
                maximum = value;
                base.OnPropertyChanged("Maximum");
            }
        }

        private double minimum;

        public double Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                minimum = value;
                base.OnPropertyChanged("Minimum");
            }
        }

        private double? _value;

        public double? Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                base.OnPropertyChanged("Value");
            }
        }
        
        
        
        
    }
}
