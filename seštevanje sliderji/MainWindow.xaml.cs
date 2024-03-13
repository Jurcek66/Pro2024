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

namespace seštevanje_sliderji
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
        int stevilo1;
        int stevilo2;

        private void stotice1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte stot1 = (byte)stotice1.Value;
            byte des1 = (byte)desetice1.Value;
            byte en1 = (byte)enice1.Value;

            stevilo1 = stot1 * 100 + des1 * 10 + en1;
            st1.Text = stevilo1.ToString();
        }

        private void desetice1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte stot1 = (byte)stotice1.Value;
            byte des1 = (byte)desetice1.Value;
            byte en1 = (byte)enice1.Value;

            stevilo1 = stot1 * 100 + des1 * 10 + en1;
            st1.Text = stevilo1.ToString();
        }

        private void enice1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte stot1 = (byte)stotice1.Value;
            byte des1 = (byte)desetice1.Value;
            byte en1 = (byte)enice1.Value;

            stevilo1 = stot1 * 100 + des1 * 10 + en1;
            st1.Text = stevilo1.ToString();
        }

        private void stotice2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte stot2 = (byte)stotice2.Value;
            byte des2 = (byte)desetice2.Value;
            byte en2 = (byte)enice2.Value;

            stevilo2 = stot2 * 100 + des2 * 10 + en2;
           

        }

        private void desetice2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte stot2 = (byte)stotice2.Value;
            byte des2 = (byte)desetice2.Value;
            byte en2 = (byte)enice2.Value;

            stevilo2 = stot2 * 100 + des2 * 10 + en2;
            st2.Text = stevilo2.ToString();
        }

        private void enice2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte stot2 = (byte)stotice2.Value;
            byte des2 = (byte)desetice2.Value;
            byte en2 = (byte)enice2.Value;

            stevilo2 = stot2 * 100 + des2 * 10 + en2;
            st2.Text = stevilo2.ToString();
        }

        private void izračun_Click(object sender, RoutedEventArgs e)
        {
            int rezltat = stevilo1 + stevilo2;
            rez.Text = rezltat.ToString();
        }
    }
}
