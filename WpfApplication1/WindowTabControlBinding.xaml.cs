using Common;
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
    /// Interaction logic for WindowTabControlBinding.xaml
    /// </summary>
    public partial class WindowTabControlBinding : Window
    {
        public WindowTabControlBinding()
        {
            MyPro = "root prp";
            InitializeComponent();
            Tabs.Add(1);
            Tabs.Add(2);
            Tabs.Add(3);
            Tabs.Add(new TabControlViewModel()
            {
                 Name="myUI"
            });
            Tabs.Add(4);
            this.DataContext = this;
            SelecteItem = Tabs[0];
        }

        private string myVar;

        public string MyPro
        {
            get
            {
                return myVar;
            }
            set
            {
                myVar = value;
            }
        }


        private List<object> _Tabs=new List<object> ();

        public List<object> Tabs
        {
            get
            {
                return _Tabs;
            }
            set
            {
                _Tabs = value;
            }
        }

        private object selecteitem;

        public object SelecteItem
        {
            get
            {
                return selecteitem;
            }
            set
            {
                selecteitem = value;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabControl tc; 
            var a = new TabItem();
            a.Header = "this is special";
            a.Content = "dfdf";

            this.tcResult.Items.Add(a);
           
         }

        private void tcResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //var newTab=(TabItem) e.AddedItems[0];
            //if (newTab != null)
            //{

            //}

            //var obj = (TabItem)tcResult.ItemContainerGenerator.ContainerFromIndex(1);
            //if (obj != null)
            //{
               
            //}
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string str = sender.GetHashCode().ToString();

        }

        private void btnSimple_Click(object sender, RoutedEventArgs e)
        {
            string str = sender.GetHashCode().ToString();
        }
    }

    public class TabControlViewModel : BaseViewModel
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

    public class TemplateSelector :DataTemplateSelector 
    {

        private DataTemplate myTemplate;

        public DataTemplate ComplexTemplate
        {
            get
            {
                return myTemplate;
            }
            set
            {
                myTemplate = value;
            }
        }


        private DataTemplate simpleTemplate;

        public DataTemplate SimpleTemplate
        {
            get
            {
                return simpleTemplate;
            }
            set
            {
                simpleTemplate = value;
            }
        }
        
        
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        { 
             if (item is TabControlViewModel)
            {
                return ComplexTemplate;
            }
            return SimpleTemplate;
        }
    }


}
