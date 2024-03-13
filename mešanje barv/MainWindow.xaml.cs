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

namespace mešanje_barv
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
        private void slidervalue()
        {

        }

        private void Rdeča_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)Rdeča.Value;
            byte g = (byte)Zelena.Value;
            byte b = (byte)Modra.Value;
            p1.Fill = new SolidColorBrush(Color.FromArgb(255, r, g, b));
        }

        private void Zelena_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)Rdeča.Value;
            byte g = (byte)Zelena.Value;
            byte b = (byte)Modra.Value;
            p1.Fill = new SolidColorBrush(Color.FromArgb(255, r, g, b));
        }

        private void Modra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)Rdeča.Value;
            byte g = (byte)Zelena.Value;
            byte b = (byte)Modra.Value;
            p1.Fill = new SolidColorBrush(Color.FromArgb(255, r, g, b));
        }
    }
}
