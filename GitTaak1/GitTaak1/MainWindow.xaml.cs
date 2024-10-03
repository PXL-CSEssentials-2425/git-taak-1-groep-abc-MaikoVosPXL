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

namespace GitTaak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_MouseEnter_Rood(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));

        }

        private void Button_MouseLeave_Rood(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));

        }

        private void Button_MouseEnter_Geel(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));

        }

        private void Button_MouseLeave_Geel(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));

        }

        private void Button_MouseEnter_Blauw(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0000FF"));

        }

        private void Button_MouseLeave_Blauw(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));

        }

        private void Button_MouseEnter_Groen(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#008000"));

        }

        private void Button_MouseLeave_Groen(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));

        }

        private void Button_Click_Rood(object sender, RoutedEventArgs e)
        {
            colorCode.Text = "Rood: #FF0000";
        }

        private void Button_Click_Geel(object sender, RoutedEventArgs e)
        {
            colorCode.Text = "Geel: #FFFF00";
        }

        private void Button_Click_Blauw(object sender, RoutedEventArgs e)
        {
            colorCode.Text = "Blauw: #0000FF";
        }

        private void Button_Click_Groen(object sender, RoutedEventArgs e)
        {
            colorCode.Text = "Groen: #008000";
        }

    }
}
