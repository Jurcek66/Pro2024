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

namespace okenska_aplikacija
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
        private void Seštej()
        {
            int a = int.Parse(prvaST.Text);
            int b = int.Parse(drugaST.Text);
            float rez = a + b;
            rezultat.Text = rez + " ";
            if (neg_vr.IsChecked == true)
                if (rez < 0)
                    rezultat.Foreground = new SolidColorBrush(Colors.Red);

        }
        private void Odštej()
        {
            int a = int.Parse(prvaST.Text);
            int b = int.Parse(drugaST.Text);
            float rez = a - b;
            rezultat.Text = rez + " ";
            if (neg_vr.IsChecked == true)
                if (rez < 0)
                    rezultat.Foreground = new SolidColorBrush(Colors.Red);
        }
        private void Množi()
        {
            int a = int.Parse(prvaST.Text);
            int b = int.Parse(drugaST.Text);
            float rez = a * b;
            rezultat.Text = rez + " ";
            if (neg_vr.IsChecked == true)
                if (rez < 0)
                    rezultat.Foreground = new SolidColorBrush(Colors.Red);
        }
        private void Deli()
        {
            int a = int.Parse(prvaST.Text);
            int b = int.Parse(drugaST.Text);
            float rez = a / b;
            rezultat.Text = rez + " ";
            if (neg_vr.IsChecked == true)
                if (rez < 0)
                    rezultat.Foreground = new SolidColorBrush(Colors.Red);
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void izračunaj_Click(object sender, RoutedEventArgs e)
        {
            if (seštevanje.IsChecked == true)
                Seštej();
            if (odštevanje.IsChecked == true)
                Odštej();
            if (Množenje.IsChecked == true)
                Množi();
            if (deljenje.IsChecked == true)
                Deli();
        }
    }
}
