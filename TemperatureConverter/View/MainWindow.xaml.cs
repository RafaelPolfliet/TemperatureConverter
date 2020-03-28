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

namespace View
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

      

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            Double cels = Double.Parse(textBoxCelsius.Text);

            Double fahr = cels * 9 / 5 + 32;

            Double kelv = cels + 273.15;

            textBoxFahrenheit.Text = fahr.ToString();
            textBoxKelvin.Text = kelv.ToString();
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            Double fahr = Double.Parse(textBoxFahrenheit.Text);

            Double cels = (fahr - 32) * 5 / 9;

            Double kelv = cels + 273.15;

            textBoxCelsius.Text = cels.ToString();
            textBoxKelvin.Text = kelv.ToString();
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            Double kelv = Double.Parse(textBoxKelvin.Text);

            Double cels = kelv - 273.15;

            Double fahr = cels * 9 / 5 + 32;

            textBoxFahrenheit.Text = fahr.ToString();
            textBoxCelsius.Text = cels.ToString();
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Double kelv = kelvinSlider.Value;

            Double cels = kelv - 273.15;

            Double fahr = cels * 9 / 5 + 32;

            textBoxFahrenheit.Text = fahr.ToString();
            textBoxCelsius.Text = cels.ToString();
        }
    }
}
