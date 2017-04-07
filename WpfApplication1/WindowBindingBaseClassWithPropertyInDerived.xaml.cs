using Common;
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
    /// Interaction logic for WindowBindingBaseClassWithPropertyInDerived.xaml
    /// </summary>
    public partial class WindowBindingBaseClassWithPropertyInDerived : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public WindowBindingBaseClassWithPropertyInDerived()
        {
            InitializeComponent();


            this.DataContext = this;
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            this.VM = new DerivedTestClass()
            {
                Name = "name1111",
                Name2 = "name22222"
            };
        }
        private BaseTestViewModel vm;


        public BaseTestViewModel VM
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
    }

    public class BaseTestViewModel : BaseViewModel
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                base.OnPropertyChanged("Name");
            }
        }

    }

    public class DerivedTestClass : BaseTestViewModel
    {

        private string name2;

        public string Name2
        {
            get
            {
                return name2;
            }
            set
            {
                name2 = value;
                base.OnPropertyChanged("Name");
            }
        }

    }


}
