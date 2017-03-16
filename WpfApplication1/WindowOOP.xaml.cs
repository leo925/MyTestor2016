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
    /// Interaction logic for WindowOOP.xaml
    /// </summary>
    public partial class WindowOOP : Window
    {
        public WindowOOP()
        {
            InitializeComponent();
            //TimeSpan ts = DateTime.Now - DateTime.Now.AddYears(-991).AddDays(-2).AddHours(-1).AddMinutes(-2);
            //string str = string.Format("{0:d3}:{1:d2}:{2:d2}", ts.Hours+24*ts.Days, ts.Minutes, ts.Seconds);
            //string dfdf = str;
            //ToolTip tip = new System.Windows.Controls.ToolTip();
            
        }

        private void ComboBox_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            ComboBox cb = new ComboBox();
        }

        private void ComboBox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            box.Items.Add(new ComboBoxItem() {
                  Content="new"
            });
        }
    }

    public interface IHaveDinner
    {
        void Eat();
    }

    public abstract class Person : IHaveDinner
    {
        public void Eat()
        {
            BeforeEat();
            EatMeal();
            AfterEat();
        }

        protected abstract void BeforeEat();

        protected abstract void EatMeal();

        protected virtual void AfterEat()
        {
            Console.WriteLine("drink ");
        }
    }


    public class Student : Person
    {
        protected override void BeforeEat()
        {
            
        }

        protected override void EatMeal()
        {
            Console.WriteLine("have rice .... ");
        }
    }

    public class Teacher : Person
    {
        protected override void BeforeEat()
        {
            Console.WriteLine("have a walk ");
        }

        protected override void EatMeal()
        {
            Console.WriteLine("have rice .... ");
        }

        protected override void AfterEat()
        {
            Console.WriteLine("sleep ");
        }
    }







    //    <Grid Margin = "40,30,46,46" >
    //    < Grid.Resources >
    //        < Style x:Key="btnLogoStyle" TargetType="{x:Type Button}">
    //            <Setter Property = "Background" Value="LightGray"/>
    //            <Setter Property = "BorderThickness" Value="0"/>
    //            <Style.Triggers>
    //                <Trigger Property = "IsMouseOver" Value="True">
    //                    <Setter Property = "Background" Value="LawnGreen"/>
    //                </Trigger>
    //            </Style.Triggers>
    //        </Style>
    //        <Style x:Key="imageStyle" TargetType="{x:Type Image}">
    //            <Style.Triggers>
    //                <Trigger Property = "IsMouseOver" Value="True">
    //                    <Setter Property = "Opacity" Value="0.25"/>
    //                    <Setter Property = "Panel.ZIndex" Value="0"/>
    //                </Trigger>
    //            </Style.Triggers>
    //        </Style>
    //    </Grid.Resources>
    //    <Grid.RowDefinitions>
    //        <RowDefinition Height = "250" />
    //        < RowDefinition Height="*" />
    //    </Grid.RowDefinitions>
    //    <Grid.ColumnDefinitions>
    //        <ColumnDefinition Width = "310" />
    //        < ColumnDefinition Width="*"/>
    //        <ColumnDefinition Width = "*" />
    //        < ColumnDefinition Width="*"/>
    //    </Grid.ColumnDefinitions>
    //        <StackPanel Grid.Row="0" Grid.Column= "0" Background= "White" >
    //            < Button Name= "btnLogoUpload" Click= "btnLogoUpload_Click" Width= "140" Height= "140" Margin= "20,20,0,0" HorizontalAlignment= "Left" Style= "{StaticResource btnLogoStyle}" >
    //            < Canvas >
    //                < Image Name= "imageLogo" Stretch= "Fill" Margin= "-70,-70,-1,-1" Width= "140" Height= "140" Style= "{StaticResource imageStyle}" Panel.ZIndex= "2" />
    //                < TextBlock Name= "tbUpload" Text = "UPLOAD" Foreground= "White" Margin= "-20,-10,0,0" Panel.ZIndex= "1" ></ TextBlock >
    //            </ Canvas >
    //        </ Button >
    //        < TextBlock Name= "tbErrorMessage" Height= "53" HorizontalAlignment= "Left" Margin= "20,16,0,10" Text= "{ResxMarkup Key=L_TipsForLogoFile}" VerticalAlignment= "Top" Width= "270" TextWrapping= "Wrap" Foreground= "Gray" />
    //    </ StackPanel >
    //    < UniformGrid Grid.Row= "0" Grid.Column= "1" Grid.ColumnSpan= "2" >
    //        < Border  Margin= "10,0,0,0" Background= "#2D68CF" >
    //            < StackPanel Orientation= "Vertical" >
    //                < StackPanel Orientation= "Horizontal" Margin= "13,13,0,0" >
    //                    < Grid Height= "24" Width= "24" >
    //                        < Path HorizontalAlignment= "Center" VerticalAlignment= "Center" Data= "F1M16.5,0L0.782,0C0.36,0,0,0.36,0,0.781L0,21.219C0,21.641,0.36,22,0.782,22L16.5,22C16.938,22,17.282,21.641,17.282,21.219L17.282,0.781C17.282,0.36,16.938,0,16.5,0 M6.282,3.531C6.282,3.313,6.453,3.141,6.672,3.141L7.469,3.141C7.688,3.141,7.86,3.313,7.86,3.531L7.86,4.328C7.86,4.547,7.688,4.719,7.469,4.719L6.672,4.719C6.453,4.719,6.282,4.547,6.282,4.328L6.282,3.531 M6.282,6.688C6.282,6.453,6.453,6.281,6.672,6.281L7.469,6.281C7.688,6.281,7.86,6.453,7.86,6.688L7.86,7.469C7.86,7.688,7.688,7.86,7.469,7.86L6.672,7.86C6.453,7.86,6.282,7.688,6.282,7.469L6.282,6.688 M6.282,9.828C6.282,9.61,6.453,9.438,6.672,9.438L7.469,9.438C7.688,9.438,7.86,9.61,7.86,9.828L7.86,10.61C7.86,10.828,7.688,11,7.469,11L6.672,11C6.453,11,6.282,10.828,6.282,10.61L6.282,9.828 M6.282,12.969C6.282,12.75,6.453,12.578,6.672,12.578L7.469,12.578C7.688,12.578,7.86,12.75,7.86,12.969L7.86,13.75C7.86,13.969,7.688,14.141,7.469,14.141L6.672,14.141C6.453,14.141,6.282,13.969,6.282,13.75L6.282,12.969 M4.719,16.891C4.719,17.11,4.547,17.281,4.328,17.281L3.532,17.281C3.313,17.281,3.141,17.11,3.141,16.891L3.141,16.11C3.141,15.891,3.313,15.719,3.532,15.719L4.328,15.719C4.547,15.719,4.719,15.891,4.719,16.11L4.719,16.891 M4.719,13.75C4.719,13.969,4.547,14.141,4.328,14.141L3.532,14.141C3.313,14.141,3.141,13.969,3.141,13.75L3.141,12.969C3.141,12.75,3.313,12.578,3.532,12.578L4.328,12.578C4.547,12.578,4.719,12.75,4.719,12.969L4.719,13.75 M4.719,10.61C4.719,10.828,4.547,11,4.328,11L3.532,11C3.313,11,3.141,10.828,3.141,10.61L3.141,9.828C3.141,9.61,3.313,9.438,3.532,9.438L4.328,9.438C4.547,9.438,4.719,9.61,4.719,9.828L4.719,10.61 M4.719,7.469C4.719,7.688,4.547,7.86,4.328,7.86L3.532,7.86C3.313,7.86,3.141,7.688,3.141,7.469L3.141,6.688C3.141,6.453,3.313,6.281,3.532,6.281L4.328,6.281C4.547,6.281,4.719,6.453,4.719,6.688L4.719,7.469 M4.719,4.328C4.719,4.547,4.547,4.719,4.328,4.719L3.532,4.719C3.313,4.719,3.141,4.547,3.141,4.328L3.141,3.531C3.141,3.313,3.313,3.141,3.532,3.141L4.328,3.141C4.547,3.141,4.719,3.313,4.719,3.531L4.719,4.328 M11,20.031C11,20.266,10.828,20.438,10.61,20.438L6.672,20.438C6.453,20.438,6.282,20.266,6.282,20.031L6.282,17.688C6.282,17.453,6.453,17.281,6.672,17.281L10.61,17.281C10.828,17.281,11,17.453,11,17.688L11,20.031 M11,13.75C11,13.969,10.828,14.141,10.61,14.141L9.828,14.141C9.594,14.141,9.422,13.969,9.422,13.75L9.422,12.969C9.422,12.75,9.594,12.578,9.828,12.578L10.61,12.578C10.828,12.578,11,12.75,11,12.969L11,13.75 M11,10.61C11,10.828,10.828,11,10.61,11L9.828,11C9.594,11,9.422,10.828,9.422,10.61L9.422,9.828C9.422,9.61,9.594,9.438,9.828,9.438L10.61,9.438C10.828,9.438,11,9.61,11,9.828L11,10.61 M11,7.469C11,7.688,10.828,7.86,10.61,7.86L9.828,7.86C9.594,7.86,9.422,7.688,9.422,7.469L9.422,6.688C9.422,6.453,9.594,6.281,9.828,6.281L10.61,6.281C10.828,6.281,11,6.453,11,6.688L11,7.469 M11,4.328C11,4.547,10.828,4.719,10.61,4.719L9.828,4.719C9.594,4.719,9.422,4.547,9.422,4.328L9.422,3.531C9.422,3.313,9.594,3.141,9.828,3.141L10.61,3.141C10.828,3.141,11,3.313,11,3.531L11,4.328 M14.141,16.891C14.141,17.11,13.969,17.281,13.75,17.281L12.969,17.281C12.75,17.281,12.578,17.11,12.578,16.891L12.578,16.11C12.578,15.891,12.75,15.719,12.969,15.719L13.75,15.719C13.969,15.719,14.141,15.891,14.141,16.11L14.141,16.891 M14.141,13.75C14.141,13.969,13.969,14.141,13.75,14.141L12.969,14.141C12.75,14.141,12.578,13.969,12.578,13.75L12.578,12.969C12.578,12.75,12.75,12.578,12.969,12.578L13.75,12.578C13.969,12.578,14.141,12.75,14.141,12.969L14.141,13.75 M14.141,10.61C14.141,10.828,13.969,11,13.75,11L12.969,11C12.75,11,12.578,10.828,12.578,10.61L12.578,9.828C12.578,9.61,12.75,9.438,12.969,9.438L13.75,9.438C13.969,9.438,14.141,9.61,14.141,9.828L14.141,10.61 M14.141,7.469C14.141,7.688,13.969,7.86,13.75,7.86L12.969,7.86C12.75,7.86,12.578,7.688,12.578,7.469L12.578,6.688C12.578,6.453,12.75,6.281,12.969,6.281L13.75,6.281C13.969,6.281,14.141,6.453,14.141,6.688L14.141,7.469 M14.141,4.328C14.141,4.547,13.969,4.719,13.75,4.719L12.969,4.719C12.75,4.719,12.578,4.547,12.578,4.328L12.578,3.531C12.578,3.313,12.75,3.141,12.969,3.141L13.75,3.141C13.969,3.141,14.141,3.313,14.141,3.531L14.141,4.328" Fill= "White" />
    //                    </ Grid >
    //                    < TextBlock x:Name= "txtDetailAddress" TextWrapping= "NoWrap" Style= "{StaticResource NormalTextStyle}" MaxWidth= "300" Margin= "13,0,0,0" Text= "{Binding RaceLocation.AddressLine1}" />
    //                </ StackPanel >
    //                < StackPanel Orientation= "Horizontal" Margin= "13,46,0,0" >
    //                    < Grid Height= "24" Width= "24" >
    //                        < Path HorizontalAlignment= "Center" VerticalAlignment= "Center" Data= "F1M11.141,7.422C11.141,9.469 9.469,11.141 7.422,11.141 5.391,11.141 3.719,9.469 3.719,7.422 3.719,5.375 5.391,3.703 7.422,3.703 9.469,3.703 11.141,5.375 11.141,7.422 M14.86,7.422C14.86,3.313 11.532,0 7.422,0 3.328,0 0,3.313 0,7.422 0,8.313 0.11,9.219 0.485,10.016L5.782,21.25C6.063,21.891 6.735,22.281 7.422,22.281 8.125,22.281 8.797,21.891 9.094,21.25L14.375,10.016C14.75,9.219,14.86,8.313,14.86,7.422" Fill= "White" />
    //                    </ Grid >
    //                    < TextBlock x:Name= "location" Style= "{StaticResource NormalTextStyle}" TextWrapping= "NoWrap"  MaxWidth= "300" Margin= "13,0,0,0" Text= "{Binding RaceLocation}" />
    //                </ StackPanel >
    //                < StackPanel Orientation= "Horizontal" Margin= "13,46,0,0" >
    //                    < Grid Height= "24" Width= "24" >
    //                        < Path HorizontalAlignment= "Center" VerticalAlignment= "Center"  Data= "F1M1.578,20.438L1.578,7.86 18.859,7.86 18.859,20.438 1.578,20.438 M6.281,5.5C6.281,5.719,6.109,5.891,5.891,5.891L5.109,5.891C4.891,5.891,4.719,5.719,4.719,5.5L4.719,1.969C4.719,1.75,4.891,1.578,5.109,1.578L5.891,1.578C6.109,1.578,6.281,1.75,6.281,1.969L6.281,5.5 M15.719,5.5C15.719,5.719,15.547,5.891,15.328,5.891L14.531,5.891C14.313,5.891,14.141,5.719,14.141,5.5L14.141,1.969C14.141,1.75,14.313,1.578,14.531,1.578L15.328,1.578C15.547,1.578,15.719,1.75,15.719,1.969L15.719,5.5 M20.422,4.719C20.422,3.86,19.719,3.141,18.859,3.141L17.281,3.141 17.281,1.969C17.281,0.891,16.406,0,15.328,0L14.531,0C13.453,0,12.578,0.891,12.578,1.969L12.578,3.141 7.859,3.141 7.859,1.969C7.859,0.891,6.969,0,5.891,0L5.109,0C4.031,0,3.141,0.891,3.141,1.969L3.141,3.141 1.578,3.141C0.719,3.141,0,3.86,0,4.719L0,20.438C0,21.297,0.719,22,1.578,22L18.859,22C19.719,22,20.422,21.297,20.422,20.438L20.422,4.719" Fill= "White" Style= "{DynamicResource ButtonFocusVisual}" />
    //                    </ Grid >
    //                    < Controls:DateFormat Margin = "13,0,0,0" MaxWidth= "300" ShowStyle= "{StaticResource TitleTextStyle}" BoundDate= "{Binding Path=EventDate}" />
    //                </ StackPanel >
    //            </ StackPanel >
    //        </ Border >
    //    </ UniformGrid >
    //    < UniformGrid  Grid.Row= "0" Grid.Column= "3" >
    //        < Border  Margin= "10,0,0,0" Background= "#24B24F" >
    //            < StackPanel Orientation= "Vertical" >
    //                < StackPanel Orientation= "Horizontal" Margin= "13,13,0,0" >
    //                    < Grid Height= "24" Width= "24" >
    //                        < Path Data= "F1M6.625,10C6.031,9.156 5.719,8.156 5.719,7.141 5.719,6.891 5.734,6.656 5.766,6.406 5.297,6.578 4.797,6.656 4.281,
    //                                        6.656 2.781,6.656 1.625,5.719 1.391,5.719 -0.031,5.719 0,8.75 0,9.656 0,10.891 1.047,11.422 2.172,11.422L3.656,11.422C4.406,10.531,
    //                                        5.453,10.031,6.625,10 M18.578,17.109C18.578,14.578 17.984,10.719 14.703,10.719 14.328,10.719 12.953,12.266 10.719,12.266 8.484,
    //                                        12.266 7.094,10.719 6.719,10.719 3.453,10.719 2.859,14.578 2.859,17.109 2.859,18.922 4.047,20 5.844,20L15.594,20C17.375,20,18.578,
    //                                        18.922,18.578,17.109 M7.141,2.859C7.141,1.281 5.859,0 4.281,0 2.719,0 1.422,1.281 1.422,2.859 1.422,4.422 2.719,5.719 4.281,
    //                                        5.719 5.859,5.719 7.141,4.422 7.141,2.859 M15,7.141C15,4.781 13.078,2.859 10.719,2.859 8.344,2.859 6.422,4.781 6.422,7.141 6.422,
    //                                        9.5 8.344,11.422 10.719,11.422 13.078,11.422 15,9.5 15,7.141 M21.422,9.656C21.422,8.75 21.469,5.719 20.047,5.719 19.813,5.719 18.656,
    //                                        6.656 17.141,6.656 16.625,6.656 16.141,6.578 15.656,6.406 15.688,6.656 15.719,6.891 15.719,7.141 15.719,8.156 15.391,9.156 14.813,
    //                                        10 15.969,10.031 17.016,10.531 17.766,11.422L19.266,11.422C20.375,11.422,21.422,10.891,21.422,9.656 M20,2.859C20,
    //                                        1.281 18.719,0 17.141,0 15.563,0 14.281,1.281 14.281,2.859 14.281,4.422 15.563,5.719 17.141,5.719 18.719,5.719 20,4.422 20,2.859"  Fill="White" />
    //                    </Grid>
    //                    <TextBlock x:Name= "participants" Style= "{StaticResource TableTextStyle}" MaxWidth= "300" Margin= "13,0,0,0" >< Run Text= "{ResxMarkup Key=C_Participants}" /></ TextBlock >
    //                </ StackPanel >
    //                < TextBlock x:Name= "total" FontSize= "42" FontWeight= "Light" Style= "{StaticResource TitleTextWrapStyle}" MaxWidth= "300" Margin= "50,10,0,0" >< Run Text= "1,000,000" /></ TextBlock >
    //                < Label Style= "{StaticResource NormalLabelStyle}" Margin= "50,-8,0,0" FontSize= "16" Foreground= "White" Content= "{ResxMarkup Key=P_Total}" />

    //                < StackPanel Orientation= "Vertical" Visibility= "Collapsed" >
    //                    < TextBlock x:Name= "checkedIn" FontSize= "42" FontWeight= "Light"  Style= "{StaticResource TitleTextWrapStyle}" MaxWidth= "300" Margin= "50,10,0,0" >< Run Text= "600,000" /></ TextBlock >
    //                    < Label Style= "{StaticResource NormalLabelStyle}" Margin= "50,-8,0,0" Foreground= "White" Content= "{ResxMarkup Key=O_CheckedIn}" />
    //                </ StackPanel >

    //                < TextBlock x:Name= "nobibnum" FontSize= "42" FontWeight= "Light"  Style= "{StaticResource TitleTextWrapStyle}" MaxWidth= "300" Margin= "50,10,0,0" >< Run Text= "600,000" /></ TextBlock >
    //                < Label Style= "{StaticResource NormalLabelStyle}" Margin= "50,-8,0,0" Foreground= "White" Content= "{ResxMarkup Key=O_NoBibNumber}" />

    //            </ StackPanel >
    //        </ Border >
    //    </ UniformGrid >
    //    < StackPanel Grid.Row= "1" Grid.Column= "0" >
    //            < Border Margin= "0,10,0,0"   Background= "#009DDA" >
    //                < Grid >
    //                    < Grid.RowDefinitions >
    //                        < RowDefinition Height= "200" />
    //                        < RowDefinition Height= "*" />
    //                    </ Grid.RowDefinitions >
    //                    < StackPanel Orientation= "Vertical" >
    //                        < TextBlock Margin= "20,10,0,0" Style= "{StaticResource TitleTextStyle}" Text= "{ResxMarkup Key=R_Readers}" />
    //                        < TextBlock Margin= "20,10,20,0" Style= "{StaticResource CaptionTextStyle}" Text= "{ResxMarkup Key=O_Readers_Content}" MinWidth= "240" />
    //                    </ StackPanel >
    //                    < Button x:Name= "addReaderBtn" Margin= "0,25,30,25" HorizontalAlignment= "Right" Width= "160" Style= "{DynamicResource SquareButtonStyle}"  Content= "{ResxMarkup Key=O_AddReaders}" Grid.Row= "1" Height= "32" Click= "addReaderBtn_Click" />
    //                </ Grid >
    //            </ Border >
    //        </ StackPanel >
    //    < StackPanel Grid.Row= "1" Grid.Column= "1" >
    //        < Border Margin= "10,10,0,0"   Background= "#009DDA" >
    //            < Grid >
    //                < Grid.RowDefinitions >
    //                    < RowDefinition Height= "200" />
    //                    < RowDefinition Height= "*" />
    //                </ Grid.RowDefinitions >
    //                < StackPanel Orientation= "Vertical" >
    //                    < TextBlock Margin= "20,10,0,0" Style= "{StaticResource TitleTextStyle}" Text= "{ResxMarkup Key=O_HardwareConfiguration_Title}" />
    //                    < TextBlock Margin= "20,10,20,0" Style= "{StaticResource CaptionTextStyle}" Text= "{ResxMarkup Key=O_HardwareConfiguration_Content}" MinWidth= "240" />
    //                </ StackPanel >
    //                < Button x:Name= "configureBtn" Margin= "0,25,30,25" HorizontalAlignment= "Right" Width= "160" Style= "{DynamicResource SquareButtonStyle}" Content= "{ResxMarkup Key=O_ConfigureNow}" Grid.Row= "1" Height= "32" Click= "configureBtn_Click" />
    //            </ Grid >
    //        </ Border >
    //    </ StackPanel >
    //    < StackPanel Grid.Row= "1" Grid.Column= "2" >
    //        < Border Margin= "10,10,0,0" Background= "#009DDA" >
    //            < Grid >
    //                < Grid.RowDefinitions >
    //                    < RowDefinition Height= "200" />
    //                    < RowDefinition Height= "*" />
    //                </ Grid.RowDefinitions >
    //                < StackPanel Orientation= "Vertical" >
    //                    < TextBlock Margin= "20,10,0,0" Style= "{StaticResource TitleTextStyle}" Text= "{ResxMarkup Key=P_Divisions}" />
    //                    < TextBlock Margin= "20,10,20,0" Style= "{StaticResource CaptionTextStyle}" Text= "{ResxMarkup Key=O_Division_Content}" MinWidth= "240" />
    //                </ StackPanel >
    //                < Button x:Name= "setupBtn" Margin= "0,25,30,25" HorizontalAlignment= "Right" Width= "160" Style= "{DynamicResource SquareButtonStyle}"  Content= "{ResxMarkup Key=O_SetupNow}" Grid.Row= "1" Height= "32" Click= "setupBtn_Click" />
    //            </ Grid >
    //        </ Border >
    //    </ StackPanel >
    //    < StackPanel Grid.Row= "1" Grid.Column= "3" >
    //        < Border Margin= "10,10,0,0"    Background= "#009DDA" >
    //            < Grid >
    //                < Grid.RowDefinitions >
    //                    < RowDefinition Height= "200" />
    //                    < RowDefinition Height= "*" />
    //                </ Grid.RowDefinitions >
    //                < StackPanel Orientation= "Vertical" >
    //                    < TextBlock Margin= "20,10,0,0" Style= "{StaticResource TitleTextStyle}" Text= "{ResxMarkup Key=P_Waves}" />
    //                    < TextBlock Margin= "20,10,20,0" Style= "{StaticResource CaptionTextStyle}" Text= "{ResxMarkup Key=O_Waves_Content}" MinWidth= "240" />
    //                </ StackPanel >
    //                < Button x:Name= "setupWaveBtn" Width= "160" Margin= "0,25,30,25" HorizontalAlignment= "Right" Style= "{DynamicResource SquareButtonStyle}" Content= "{ResxMarkup Key=O_SetupWaves}" Grid.Row= "1" Height= "32" Click= "setupWaveBtn_Click" />
    //            </ Grid >
    //        </ Border >
    //    </ StackPanel >
    //</ Grid >






}
