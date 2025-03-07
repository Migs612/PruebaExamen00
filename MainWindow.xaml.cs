using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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

namespace PruebaExamen00
{
    public partial class MainWindow : Window
    {
        private bool modoOscuro = true;

        public MainWindow()
        {
            InitializeComponent();
            AplicarModoClaro();
        }

        private void ToggleMode_Click(object sender, RoutedEventArgs e)
        {
            if (modoOscuro)
            {
                AplicarModoClaro();
            }
            else
            {
                AplicarModoOscuro();
            }

            modoOscuro = !modoOscuro;
        }

        private void AplicarModoClaro()
        {
            Application.Current.Resources["PrimaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F5F5F5"));
            Application.Current.Resources["SecondaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0E0E0"));
            Application.Current.Resources["TextBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1565C0"));
        }

        private void AplicarModoOscuro()
        {
            Application.Current.Resources["PrimaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121212"));
            Application.Current.Resources["SecondaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E1E1E"));
            Application.Current.Resources["TextBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00E676"));
        }
    }
}